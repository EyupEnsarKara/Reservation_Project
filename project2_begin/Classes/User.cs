using project2_begin.Forms;
using project2_begin.Forms.AdminForms;
using project2_begin.Forms.CompanyForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2_begin.Classes
{
    public abstract class User : ILoginable
    {

        public string userName { get; set; }
        public string password { get; set; }

        public User(string username, string password)
        {
            userName = username;
            this.password = password;
        }

        //Giriş yapmak için kullanılır
        public void Login(string formType,string username,string password,Label lbl_info,LoginForm loginForm)
        {
            if(formType=="admin")
            {
                AdminForm adminform = new AdminForm();
                if (username.Equals(Program.admin.userName) && password.Equals(Program.admin.password))
                {
                    adminform.Show();
                    loginForm.Close();
                }
                else
                {
                    lbl_info.Text = "Admin informations is not correct";
                    lbl_info.ForeColor = Color.Red;
                }
            }
            else if (formType == "company")
            {
                Company temp = null;
                //Firma taraması ve bulunan giriş bilgisinin ataması
                foreach (var company in Transport.Companies)
                {
                    if (username == company.userName && password == company.password)
                    {
                        temp = company;
                    }
                }

                if (temp != null)
                {
                    //başarılı giriş fonksiyonları
                    CompanyForm companyForm = new CompanyForm(temp.userName);
                    if (temp.electricPrice == 0 && temp.gasolinePrice == 0 && temp.gasPrice == 0 && temp.motorinePrice == 0)
                    {
                        CompanySetFuelCosts companySetFuelCosts = new CompanySetFuelCosts(temp,companyForm);
                        companySetFuelCosts.setLbl_info("Assign a fee on first entry");
                        companySetFuelCosts.Show();
                        loginForm.Close();

                    }
                    else
                    {
                        
                        companyForm.Show();
                        loginForm.Close();
                    }
                    
                }
                else
                {
                    //kullanıcı adı şifre bulunamadığı durum
                    lbl_info.Text = "Company not found";
                    lbl_info.ForeColor = Color.Red;
                }
            }
        }
    }
    public class Admin : User
    {

        private int serviceCost;
        public Admin(string username, string password) : base(username, password)
        {
            serviceCost = 1000;

        }
        
        public void showViewCompanyForm(AdminForm adminForm)//ViewCompanyForm'u göstermek için bir metod
        {
            AdminCompanyForm companyForm = new AdminCompanyForm(adminForm);
            companyForm.Show();
            adminForm.Hide();
        }
        public void showSetServiceCostForm(AdminForm adminForm)//SetServiceCost formunu göstermek için bir metod
        {
            AdminSetServiceCostForm setServiceCostForm = new AdminSetServiceCostForm(adminForm);
            setServiceCostForm.Show();
            adminForm.Hide();
        }
        public void setServiceServiceCost(TextBox textbox_serviceCost, Label lbl_info)//Serviceost'u ayarlamak için bir metod 
        {

            if (int.TryParse(textbox_serviceCost.Text, out int cost))
            {
                if (cost > 0)
                {
                    Program.admin.serviceCost = cost;
                    lbl_info.Text = "Value has been succesfully changed";
                    lbl_info.ForeColor = Color.Teal;
                }
                else
                {
                    lbl_info.Text = "Value is not less than 0";
                    lbl_info.ForeColor = Color.Red;
                }
            }
            else
            {
                lbl_info.Text = "Value is not usable";
                lbl_info.ForeColor = Color.Red;
            }

        }
        public int getServiceCost()
        {
            return serviceCost;
        }
        public bool deleteCompany(TextBox txtbox_companyName)//belirtilen firmayı silmek için bir metod
        {
            bool control = false;

            foreach (var company in Transport.Companies)
            {
                if (txtbox_companyName.Text == company.companyName)
                {
                    control = true;
                    Transport.Companies.Remove(company);                   
                    break;
                }
            }
            return control;
        }

        public void addCompany(Company company) {
            Transport.Companies.Add(company);
        }
    }

              
    public class Company : User,IProfitable
    {
        public string companyName;
        public static int companyCount=0;
        public int companyId;
        public List<Vehicle> vehicles=new List<Vehicle>();
        public Salaries driverSalaries;
        public Salaries helperSalaries;
        public int motorinePrice {  get; set; }
        public int gasolinePrice { get; set; }
        public int electricPrice { get; set; }
        public int gasPrice { get; set; }

        public int busCount = 0;
        public int airplaneCount = 0;
        public int trainCount = 0;

        public Company(string companyName,string username, string password,Salaries driverSalaries,Salaries helperSalaries,int motorinePrice,int gasolinePrice,int electricPrice,int gasPrice) : base(username, password)
        {
            this.companyName = companyName;
            companyId = companyCount;
            this.driverSalaries = driverSalaries;
            this.helperSalaries = helperSalaries;
            companyCount++;
            this.gasPrice = gasPrice;

            this.electricPrice = electricPrice;
            this.gasolinePrice = gasolinePrice;
            this.motorinePrice = motorinePrice;
        }
        public Company(string companyName, string username, string password) : base(username, password)
        {
            this.companyName = companyName;
            companyId = companyCount;
            companyCount++;
            this.driverSalaries = new Salaries(0, 0, 0);
            this.helperSalaries = new Salaries(0, 0, 0);
            this.motorinePrice = motorinePrice;
            this.gasolinePrice = gasolinePrice;
            this.electricPrice = electricPrice;
            this.gasPrice = gasPrice;
            this.electricPrice = 0;
            this.gasolinePrice=0;
            this.gasPrice=0;
            this.motorinePrice=0;
        }

        public void showCompanyVehicleSetForm(CompanyForm companyForm,Company company)
        {
            CompanyVehicleSet companyVehicleSet = new CompanyVehicleSet(company,companyForm);
            companyVehicleSet.Show();
            companyForm.Hide();
            
        }

        public void showCompanyTripset(CompanyForm companyForm,Company company)
        {
            ViewCompanyTrip companyTripSet = new ViewCompanyTrip(companyForm, company);
            companyTripSet.Show();
            companyForm.Hide();
        }

        public void addVehicle(Vehicle vehicle)
        {
            this.vehicles.Add(vehicle);
            if (vehicle is Bus && vehicle.vehiclefuelType == "Gasoline") vehicle.costByPerDistance = this.gasolinePrice;
            if (vehicle is Bus && vehicle.vehiclefuelType == "Motorine") vehicle.costByPerDistance = this.motorinePrice;
            if (vehicle is Train) vehicle.costByPerDistance = this.electricPrice;
            if (vehicle is AirPlane) vehicle.costByPerDistance = this.gasPrice;
           
          
        }
        public void deleteVehicle(Vehicle vehicle)
        {
            this.vehicles.Remove(vehicle);
        }

        public int CalculateDailyProfit(DateTime time)
        {
            int profit = 0;
            int revenue = 0;
            int cost = 0;

            foreach (var trip in Transport.trips)
            {

                if (time != trip.time) continue;

                if (trip.companyName == this.companyName)
                {
                    foreach (var reservation in Transport.reservations)
                    {
                        if (reservation.tripId != trip.tripId) continue;
                        //Console.WriteLine(reservation.tripId);
                        //revenue += reservation.passenger.route.price;
                        revenue += Funcitons.sumRoutePrice(trip);


                    }

                    if (trip.vehicle.vehicleType == "Bus")
                    {
                        cost += driverSalaries.busSalary * 4;
                        cost += helperSalaries.busSalary * 4;
                        
                    }
                    if (trip.vehicle.vehicleType == "Train")
                    {
                        cost += driverSalaries.trainSalary * 4;
                        cost += helperSalaries.trainSalary * 4;
                    }
                    if (trip.vehicle.vehicleType == "Airplane")
                    {
                        cost += driverSalaries.airplaneSalary * 4;
                        cost += helperSalaries.airplaneSalary * 4;
                    }
                    
                  foreach(var vehicle in Transport.vehicles)
                    {
                        if(vehicle.vehicleId ==trip.vehicle.vehicleId)
                        {
                           cost+=(trip.vehicle.costByPerDistance) * (trip.getFulldistance());

                        }
                    }

                }
            }
            cost += Program.admin.getServiceCost();
            profit = revenue - cost;
            return profit;  
        }

        public int CalculateOverallProfitLoss()
        {
            int allProfit = 0;
            for(int i=4; i<=10; i++)
            {
                allProfit+= CalculateDailyProfit(new DateTime(2023,12,i));
            }
            return allProfit;
        }

    }
}