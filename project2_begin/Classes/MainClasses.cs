using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project2_begin.Classes
{
    public abstract class Vehicle 
    {
        public  static int tempId = 1;
        public int vehicleId { get; set; }
        public int PassengerCapacity { get; set; }
        public int costByPerDistance { get; set; }
        public string name { get; set; }
        public int companyId { get; set;}
        public string vehicleType {  get; set; }
        public string vehiclefuelType { get; set; }
        public List<Personel> personel = new List<Personel>();
        public Vehicle()
        {
            
        }
        public void addPersonelInformation(Company company, string firstName, string lastName, string role)
        {
            int salary = 0;
            if (role == "Driver")
            {
                if (this.vehicleType == "Bus") salary = company.driverSalaries.busSalary;
                if (this.vehicleType == "Train") salary = company.driverSalaries.trainSalary;
                if (this.vehicleType == "Airplane") salary = company.driverSalaries.airplaneSalary;
            }
            else if (role == "Helper")
            {
                if (this.vehicleType == "Bus") salary = company.helperSalaries.busSalary;
                if (this.vehicleType == "Train") salary = company.helperSalaries.trainSalary;
                if (this.vehicleType == "Airplane") salary = company.helperSalaries.airplaneSalary;
            }
            this.personel.Add(new Personel(role, salary, firstName, lastName));
        }
    }

    class Bus : Vehicle
    {
        public Bus(int PassengerCapacity, int companyId,string vehicleFuelType,Company company)
        {
            this.costByPerDistance = costByPerDistance;
            this.PassengerCapacity = PassengerCapacity;
            this.vehicleId = tempId;
            tempId++;
            name = "Bus " + (company.busCount+1);
            company.busCount++;
            this.companyId = companyId;
            this.vehicleType = "Bus";
            this.vehiclefuelType = vehicleFuelType;
            addPersonelInformation(company, "", "", "Driver");
            addPersonelInformation(company, "", "", "Driver");
            addPersonelInformation(company, "", "", "Helper");
            addPersonelInformation(company, "", "", "Helper");

        }
    }

    class Train : Vehicle
    {
        public Train(int PassengerCapacity, int companyId,string vehicleFuelType,Company company)
        {
            this.costByPerDistance = costByPerDistance;
            this.PassengerCapacity = PassengerCapacity;
            this.vehicleId = tempId;
            tempId++;
            name = "Train " + (company.trainCount+1);
            company.trainCount++;
            this.companyId = companyId;
            this.vehicleType = "Train";
            this.vehiclefuelType = vehicleFuelType;
            addPersonelInformation(company, "", "", "Driver");
            addPersonelInformation(company, "", "", "Driver");
            addPersonelInformation(company, "", "", "Helper");
            addPersonelInformation(company, "", "", "Helper");
        }

    }

    class AirPlane : Vehicle
    {
        public AirPlane(int PassengerCapacity, int companyId, string vehicleFuelType,Company company)
        {
            this.costByPerDistance = costByPerDistance;
            this.PassengerCapacity = PassengerCapacity;
            this.vehicleId = tempId;
            tempId++;
            name = "Airplane " + (company.airplaneCount+1);
            company.airplaneCount++;
            this.companyId = companyId;
            this.vehicleType = "Airplane";
            this.vehiclefuelType = vehicleFuelType;
            addPersonelInformation(company, "", "", "Driver");
            addPersonelInformation(company, "", "", "Driver");
            addPersonelInformation(company, "", "", "Helper");
            addPersonelInformation(company, "", "", "Helper");
        }
    }

    //Ekstra class tanımlamaları


    public class Trip
    {
        

        public int tripId;
        static int tripcount = 1;
        public string tripType { get; set; }
        public string companyName { get; set;}

        public Vehicle vehicle { get; set; }
        public int passengerCount { get; set; }

        public List<Route> goingRoute =new List<Route>();
        public List<Route> returnRoute =new List<Route>();
        public DateTime time { get; set; }

       
        
        public Trip(string tripType,int passengerCount,string companyName)
        {

            this.tripId = tripcount;
            tripcount++;
            this.passengerCount = passengerCount;
            this.tripType = tripType;
            this.companyName = companyName;

        }
        public Trip()
        {
            
        }
        public List<Route> sumRoutes()
        {
            List<Route> tempRoutes = new List<Route>();
            tempRoutes.AddRange(this.goingRoute); 
            tempRoutes.AddRange(this.returnRoute);
            return tempRoutes;


        }
      
        public int emptySeatsCount(Trip trip,Route route)
        {
            int count = 0;
            for (int i = 0; i < trip.passengerCount; i++)
            {
                if (Program.transport.CheckSeatStatus(i, trip, route)) count++;
            }
            return count;
        }
        public int getFulldistance()
        {
            double cost = 0;
            foreach (Route route in this.sumRoutes())
                cost += route.Distance;

            return (int)cost;
        }       
    }
    public class Route
    {
        public string Deparature { get; set; }
        public string Destination { get; set; }
        public double Distance { get; set; }
        public int price { get; set; }

        public List<bool> isEmptySeat = null;
        public Route(string Deparature, string Destination, double Distance, int price)
        {
            this.Deparature = Deparature;
            this.Destination = Destination;
            this.Distance = Distance;
            this.price = price;           
        }

        public Route(string Deparature, string Destination)
        {
            this.Deparature = Deparature;
            this.Destination = Destination;
         
        }
        public Route()
        {
            
        }
        public void CalculateCost(Trip trip)
        {
            int startIndex = -1;
            int endIndex = -1;
            int control = -1;
            this.price = 0;
            this.Distance = 0;

            foreach (Route rt in trip.goingRoute)
            {
                if (this.Deparature == rt.Deparature)
                {
                    startIndex = trip.goingRoute.IndexOf(rt);
                    
                }
                if (this.Destination == rt.Destination)
                {
                    endIndex = trip.goingRoute.IndexOf(rt);
                    

                }
                if (startIndex != -1 && endIndex != -1) { control = 0; }

            }
            
            if (control!=0)
            {
                foreach (Route rt in trip.returnRoute)
                {
                    if (this.Deparature == rt.Deparature)
                    {
                        startIndex = trip.returnRoute.IndexOf(rt);
                        
                    }
                    if ((this.Destination == rt.Destination))
                    {
                        endIndex = trip.returnRoute.IndexOf(rt);
                        
                    }
                    if (startIndex != -1 && endIndex != -1) { control = 1; }
                }
                

            }
            if (control == 0)
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    
                    this.price += trip.goingRoute[i].price;
                    this.Distance += trip.goingRoute[i].Distance;

                }
            }
            if(control==1)
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    
                   this.price += trip.returnRoute[i].price;
                    this.Distance += trip.returnRoute[i].Distance;

                }

            }

           
        }
        public int getAvaibleSeatCount()
        {
            int count = 0;
            for(int i = 0; i < this.isEmptySeat.Count; i++) {
                if (!this.isEmptySeat[i]) { count++; }
            }
            return count;
        }
        

    }

    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class Personel : Person
    {
        public string Role { get; set; }
        public int Salary { get; set; }
        public Personel(string Role,int Salary,string name,string surname)
        {
            this.Role = Role;
            this.Salary = Salary;
            this.firstName = name;
            this.lastName = surname;
        }
        public Personel()
        {
            
        }

    }
    public class Salaries
    {
        public int busSalary { get; set; }
        public int trainSalary { get; set; }
        public int airplaneSalary { get; set; }
        public Salaries(int busSalary,int trainSalary,int airplaneSalary)
        {
            this.airplaneSalary = airplaneSalary;
            this.busSalary = busSalary;
            this.trainSalary = trainSalary;
        }
        public Salaries()
        {
            
        }
    }

    public class Passenger : Person
    {
        

       public string TC { get; set; } 
       public DateTime bornDate  { get; set; }
       public Route route { get; set; }

        public Passenger(string firstName,string lastName,string TC, DateTime bornDate, Route route)
        {
            this.TC = TC;
            this.bornDate = bornDate;
            this.route = route;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Passenger()
        {
            
        }


    }

    public class Reservation
    {
        public Vehicle vehicle { get; set; }
        public Passenger passenger { get; set; }
        
        public int seat { get; set; }
        public int price { get; set; }
        public int tripId { get; set; }


        public Reservation(Vehicle vehicle, Passenger passenger, int seat, int tripId)
        {
            this.vehicle = vehicle;
            this.passenger = passenger;
            this.seat = seat;
            this.tripId = tripId;

        }
        public Reservation(Vehicle vehicle,int seat, int tripId)
        {
            this.vehicle = vehicle;
            this.seat = seat;
            this.tripId = tripId;

        }
        public Reservation()
        {
            
        }
    }


    public class Transport : IReservable
    {
        public static List<Company> Companies= new List<Company>();
        public static List<Vehicle> vehicles =new List<Vehicle>();
        public static List<Trip> trips = new List<Trip>();
        public static List<Reservation> reservations = new List<Reservation>();
        
        public bool CheckSeatStatus(int seatNo,Trip trip,Route route)
        {
            bool control = false;
            foreach (Route routes in trip.sumRoutes())
            {
                if (routes.Deparature == route.Deparature || control)
                {

                    control = true;
                    if (routes.isEmptySeat[seatNo])
                    {       
                        return false;
                        
                    }
                    if (routes.Destination == route.Destination)
                        break;

                }
            }
            return true;

        }

        public void ReserveSeat(Trip trip,int seatNo,Passenger passenger,Route route)
        {
            reservations.Add(new Reservation(trip.vehicle, passenger, seatNo,trip.tripId));
            bool control=false;
            foreach (Route routes in trip.sumRoutes())
            {   
                if (routes.Deparature == route.Deparature||control)
                {
                    
                    control = true;
                    routes.isEmptySeat[seatNo] = true;

                    if (routes.Destination == route.Destination)
                        break;

                }
            }


        }
        public void ReserveSeat(Trip trip, int seatNo,Route route)
        {
            
            reservations.Add(new Reservation(trip.vehicle,seatNo, trip.tripId));
            bool control = false;
            foreach (Route routes in trip.sumRoutes())
            {
                if (routes.Deparature == route.Deparature || control)
                {

                    control = true;
                    
                    routes.isEmptySeat[seatNo] = true;

                    if (routes.Destination == route.Destination)
                        break;

                }
            }
        }

    }



    public static class defaultTrip
    {


        public static List<Route> goingRoutes1 = new List<Route>
            {
                new Route("İstanbul", "Kocaeli", 75, 50),
                new Route("Kocaeli", "Bilecik", 75, 50),
                new Route("Bilecik", "Eskişehir", 75, 50),
                new Route("Eskişehir", "Ankara", 150, 100),
            };
        public static List<Route> returnRoutes1 = new List<Route>
            {
                new Route("Ankara", "Eskişehir", 150, 100),
                new Route("Eskişehir", "Bilecik", 75, 50),
                new Route("Bilecik", "Kocaeli", 75, 50),
                new Route("Kocaeli", "İstanbul", 75, 50)
            };
        public static List<Route> goingRoutes2 = new List<Route>
            {
                new Route("İstanbul", "Kocaeli", 75, 50),
                new Route("Kocaeli", "Bilecik", 75, 50),
                new Route("Bilecik", "Eskişehir", 75, 50),
                new Route("Eskişehir", "Konya", 225, 150),
            };
        public static List<Route> returnRoutes2 = new List<Route>
            {
                new Route("Konya", "Eskişehir", 225, 150),
                new Route("Eskişehir", "Bilecik", 75, 50),
                new Route("Bilecik", "Kocaeli", 75, 50),
                new Route("Kocaeli", "İstanbul", 75, 50)
            };
        public static List<Route> goingRoutes3 = new List<Route>
            {
                new Route("İstanbul", "Kocaeli", 100, 50),
                new Route("Kocaeli", "Ankara", 400, 400),
            };
        public static List<Route> returnRoutes3 = new List<Route>
            {
                new Route("Ankara", "Kocaeli", 400, 400),
                new Route("Kocaeli", "İstanbul", 100, 50),
            };
        public static List<Route> goingRoutes4 = new List<Route>
            {
                new Route("İstanbul", "Kocaeli", 100, 50),
                new Route("Kocaeli", "Eskişehir", 300, 200),
                new Route("Eskişehir", "Konya", 225, 225),
            };
        public static List<Route> returnRoutes4 = new List<Route>
            {
                new Route("Konya", "Eskişehir", 225, 225),
                new Route("Eskişehir", "Kocaeli", 300, 200),
                new Route("Kocaeli", "İstanbul", 100, 50)
            };
        public static List<Route> goingRoutes5 = new List<Route>
            {
                new Route("İstanbul", "Konya", 300, 1200),
            };
        public static List<Route> returnRoutes5 = new List<Route>
            {
                new Route("Konya", "İstanbul", 300, 1200)
            };
        public static List<Route> goingRoutes6 = new List<Route>
            {
                new Route("İstanbul", "Ankara", 250, 1000)
            };
        public static List<Route> returnRoutes6 = new List<Route>
            {
                new Route("Ankara", "İstanbul", 250, 1000)
            };
        public static List<Route> returnroute(string vehicleType)
        {
            List<Route> temproutes = new List<Route>();
            if (vehicleType != null)
            {
                if (vehicleType == "Train")
                {
                    temproutes.AddRange(goingRoutes1);
                    temproutes.AddRange(goingRoutes2);
                    temproutes.AddRange(returnRoutes1);
                    temproutes.AddRange(returnRoutes2);

                    return temproutes;
                }
                if (vehicleType == "Bus")
                {
                    temproutes.AddRange(goingRoutes3);
                    temproutes.AddRange(goingRoutes4);                    
                    temproutes.AddRange(returnRoutes3);
                    temproutes.AddRange(returnRoutes4);
                    return temproutes;


                }
                if (vehicleType == "Airplane")
                {
                    temproutes.AddRange(goingRoutes5);
                    temproutes.AddRange(goingRoutes6);                    
                    temproutes.AddRange(returnRoutes5);
                    temproutes.AddRange(returnRoutes6);
                    return temproutes;

                }

            }
            return null;

        }


        public static List<List<Route>> lists=new List<List<Route>>();

        public static void addList(string vehicleType)
        {
            lists.Clear();

            if (vehicleType == "Train") { 
               lists.Add(goingRoutes1);
               lists.Add(goingRoutes2);
               lists.Add(returnRoutes1);
               lists.Add(returnRoutes2);
            }
            if (vehicleType == "Bus")
            {
                lists.Add(goingRoutes3);
                lists.Add(returnRoutes3);
                lists.Add(goingRoutes4);
                lists.Add(returnRoutes4);
            }
            if (vehicleType == "Airplane")
            {
                lists.Add(goingRoutes5);
                lists.Add(returnRoutes5);
                lists.Add(goingRoutes6);
                lists.Add(returnRoutes6);
            }

        }

        
    }
}
