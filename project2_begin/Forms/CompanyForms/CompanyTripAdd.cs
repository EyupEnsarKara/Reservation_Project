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
using System.Drawing;

namespace project2_begin.Forms.CompanyForms
{
    public partial class CompanyTripAdd : Form
    {
        private Company company;
        private Vehicle vehicle = null;
        private ViewCompanyTrip ViewCompanyTripForm;
        private string tripSelection1 = "Demiryolu: Istanbul - Kocaeli - Bilecik - Eskisehir - Ankara - Eskisehir - Bilecik - Kocaeli - Istanbul (gidiş-dönüş)";
        private string tripSelection2 = "Demiryolu: Istanbul - Kocaeli - Bilecik - Eskisehir - Konya - Eskisehir - Bilecik - Kocaeli - Istanbul (gidiş-dönüş)";
        private string tripSelection3 = "Karayolu: Istanbul - Kocaeli - Ankara - Kocaeli - Istanbul - Kocaeli - Ankara - Kocaeli - Istanbul (gidiş-dönüş)";
        private string tripSelection4 = "Karayolu: Istanbul - Kocaeli - Eskisehir - Konya - Eskisehir - Kocaeli - Istanbul (gidiş-dönüş)";
        private string tripSelection5 = "Havayolu: Istanbul - Konya - Istanbul (gidiş-dönüş)";
        private string tripSelection6 = "Havayolu: Istanbul - Ankara - Istanbul (gidiş-dönüş)";

        public CompanyTripAdd(Company company, ViewCompanyTrip viewCompanyTripForm)
        {
            InitializeComponent();
            this.company = company;
            this.ViewCompanyTripForm = viewCompanyTripForm;
            dataGridView_vehicles.Columns.Add("VehicleId", "Vehicle Id");
            dataGridView_vehicles.Columns.Add("VehicleType", "Vehicle Type");
            dataGridView_vehicles.Columns.Add("VehicleName", "Vehicle Name");
            dataGridView_vehicles.Columns.Add("VehiclePassengerCapacity", "Vehicle PassengerCapacity");
            LoadDataToGridView();          
        }
        public void LoadDataToGridView()
        {
            dataGridView_vehicles.Rows.Clear();

            foreach (var vehicle in company.vehicles)
            {
                bool control =false;
                foreach(Trip trip in Transport.trips)
                {
                    if ((trip.vehicle.vehicleId == vehicle.vehicleId)&&(trip.time==dateTimePicker1.Value)) { control = true;break; }
                }
                if (control) continue;
                if (vehicle.companyId == company.companyId)
                {
                    dataGridView_vehicles.Rows.Add(vehicle.vehicleId, vehicle.vehicleType, vehicle.name, vehicle.PassengerCapacity);
                }

            }
        }

        private void dataGridView_vehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            int selected;
            if (dataGridView_vehicles.SelectedCells.Count > 0)
            {
                selected = dataGridView_vehicles.SelectedCells[0].RowIndex;
                foreach (var vehicle in company.vehicles)
                {
                    if (dataGridView_vehicles.Rows[selected].Cells[0].Value.Equals(vehicle.vehicleId))
                    {
                        this.vehicle = vehicle;
                        lbl_vehicleId.Text=vehicle.vehicleId.ToString();
                        lbl_vehicleName.Text=vehicle.name.ToString();
                        lbl_vehicleType.Text=vehicle.vehicleType.ToString();
                        lbl_vehiclePassengersCount.Text=vehicle.PassengerCapacity.ToString();
                        break;

                    }

                }

                if (vehicle != null)
                {
                    comboBox1.Items.Clear();
                    if (vehicle.vehicleType == "Bus")
                    {
                        comboBox1.Items.Add(tripSelection3);
                        comboBox1.Items.Add(tripSelection4);
                    }
                    else if(vehicle.vehicleType =="Train")
                    {
                        comboBox1.Items.Add(tripSelection1);
                        comboBox1.Items.Add(tripSelection2);
                    }
                    else if(vehicle.vehicleType =="Airplane")
                    {
                        comboBox1.Items.Add(tripSelection5);
                        comboBox1.Items.Add(tripSelection6);
                    }
                }
            }
        }

        private void btn_addTrip_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || dateTimePicker1.Value == null)
            {
                lbl_info.Text = "Please select a valid route";
                lbl_info.ForeColor = Color.Red;
                return;
            }
            if (comboBox1.Text == tripSelection1) Funcitons.addDefaultTrip1(vehicle, company.companyName, dateTimePicker1.Value);
            else if (comboBox1.Text == tripSelection2) Funcitons.addDefaultTrip2(vehicle, company.companyName, dateTimePicker1.Value);
            else if (comboBox1.Text == tripSelection3) Funcitons.addDefaultTrip3(vehicle, company.companyName, dateTimePicker1.Value);
            else if (comboBox1.Text == tripSelection4) Funcitons.addDefaultTrip4(vehicle, company.companyName, dateTimePicker1.Value);
            else if (comboBox1.Text == tripSelection5) Funcitons.addDefaultTrip5(vehicle, company.companyName, dateTimePicker1.Value);
            else if (comboBox1.Text == tripSelection6) Funcitons.addDefaultTrip6(vehicle, company.companyName, dateTimePicker1.Value);
            lbl_info.Text = "The trip was successfully added.";
            lbl_info.ForeColor = Color.Teal;
            LoadDataToGridView();//bu formdaki datagridyenileme
            ViewCompanyTripForm.LoadDataToGridView();//önceki form datagrid yenileme
        }

        private void btn_tripMenu_Click(object sender, EventArgs e)
        {
            ViewCompanyTripForm.Show();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }

  
    }
}
