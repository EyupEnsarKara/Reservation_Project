using project2_begin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2_begin.Forms.CompanyForms
{
    public partial class CompanyVehicleSet : Form
    {
        private Company company;
        private Vehicle selectedVehicle;
        private CompanyForm companyForm;
     
        public CompanyVehicleSet(Company company,CompanyForm companyForm)
        {
            InitializeComponent();
            this.company = company;
            this.companyForm = companyForm;


            //Sütun ekleme
            dataGridViewVehicles.Columns.Add("VehicleId","Vehicle Id");
            dataGridViewVehicles.Columns.Add("VehicleType","Vehicle Type");
            dataGridViewVehicles.Columns.Add("VehicleName","Vehicle Name");
            dataGridViewVehicles.Columns.Add("VehiclePassengerCapacity","Vehicle PassengerCapacity");
            dataGridViewVehicles.Columns.Add("FuelType","Fuel Type");

            LoadDataToGridView();

        }
 

        public void LoadDataToGridView()
        {
            dataGridViewVehicles.Rows.Clear();
            
            foreach(var vehicle in company.vehicles)
            {
                if(vehicle.companyId == company.companyId)
                {
            
                    dataGridViewVehicles.Rows.Add(vehicle.vehicleId, vehicle.vehicleType,vehicle.name,vehicle.PassengerCapacity.ToString()+"/"+vehicle.personel.Count.ToString(),vehicle.vehiclefuelType);
                }
                
            }
            

        }

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            companyForm.Show();
            this.Close();
        }



        private void btn_add_Click(object sender, EventArgs e)
        {

            if (comboBox_vehicleType.Text != string.Empty && comboBox_fuelType.Text != string.Empty)
            {
                int vehiclecapacity;
                if (txtbox_vehiclecapacity.Text != string.Empty && int.TryParse(txtbox_vehiclecapacity.Text, out vehiclecapacity))
                {
                    if (comboBox_vehicleType.Text == "Bus") company.addVehicle(new Bus(vehiclecapacity, company.companyId,comboBox_fuelType.Text,company));
                    if (comboBox_vehicleType.Text == "Train") company.addVehicle(new Train(vehiclecapacity, company.companyId, comboBox_fuelType.Text,company));
                    if (comboBox_vehicleType.Text == "Airplane") company.addVehicle( new AirPlane(vehiclecapacity, company.companyId, comboBox_fuelType.Text, company));
                    LoadDataToGridView();
                    lbl_info.Text = "Vehicle addition successful";
                    lbl_info.ForeColor = Color.Teal;
                }
                else
                {
                    lbl_info.Text = "Vehicle capacity must be a number greater than 0";
                    lbl_info.ForeColor = Color.Red;
                }
            }
            else
            {
                lbl_info.Text = "The values entered cannot be empty";
                lbl_info.ForeColor = Color.Red;
            }
            //Personel ekleme fonksiyonları
            CompanyAddPersonelInformation companyAddPersonelInformation = new CompanyAddPersonelInformation(this, company.vehicles.Last(), company);
            companyAddPersonelInformation.Show();
            this.Hide();
        }

        private void dataGridViewVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected;
            if(dataGridViewVehicles.SelectedCells.Count > 0) {
                selected = dataGridViewVehicles.SelectedCells[0].RowIndex;
                int vehicleid = Convert.ToInt32(dataGridViewVehicles.Rows[selected].Cells[0].Value);
                foreach(var temp in company.vehicles)
                {
                    if(vehicleid==temp.vehicleId) this.selectedVehicle = temp;
                }
                comboBox_vehicleType.Text = this.selectedVehicle.vehicleType;
                comboBox_fuelType.Text = this.selectedVehicle.vehiclefuelType;
                txtbox_vehiclecapacity.Text = this.selectedVehicle.PassengerCapacity.ToString();
            }
        }

        private void btn_deleteVehicle_Click(object sender, EventArgs e)
        {
            if(selectedVehicle != null)
            {
                
                company.deleteVehicle(selectedVehicle);
                LoadDataToGridView();
                btn_clear_Click(sender, e);
                lbl_info.Text = "Vehicle deletion successful";
                lbl_info.ForeColor = Color.Teal;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            comboBox_fuelType.Text =null;
            comboBox_vehicleType.Text = null;
            txtbox_vehiclecapacity.Text = null;

        }

        private void comboBox_vehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_fuelType.Items.Clear();
            if (comboBox_vehicleType.SelectedItem == null)
                return;
            if(comboBox_vehicleType.SelectedItem.ToString() == "Bus")
            {
                comboBox_fuelType.Items.Add("Gasoline");
                comboBox_fuelType.Items.Add("Motorine");
            
            }
            else if(comboBox_vehicleType.SelectedItem.ToString() == "Train")
            {
                comboBox_fuelType.Items.Add("Electric");
                comboBox_fuelType.Text = "Electric";
            }
            else if (comboBox_vehicleType.SelectedItem.ToString() == "Airplane")
            {
                comboBox_fuelType.Items.Add("Gas");
                comboBox_fuelType.Text = "Gas";

            }            
        }
    }    
}
