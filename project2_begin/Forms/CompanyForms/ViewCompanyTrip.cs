using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project2_begin.Classes;
using System.Windows.Forms;

namespace project2_begin.Forms.CompanyForms
{
    public partial class ViewCompanyTrip : Form
    {
        private CompanyForm companyForm;
        private Company company;
        private Trip selectedTrip=null;
        public ViewCompanyTrip(CompanyForm companyForm,Company company)
        {
            this.companyForm = companyForm;
            this.company = company;
            InitializeComponent();

            dataGridView_trips.Columns.Add("TripId", "Trip Id");
            dataGridView_trips.Columns.Add("VehicleType", "Vehicle Type");
            dataGridView_trips.Columns.Add("VehicleName", "Vehicle Name");
            dataGridView_trips.Columns.Add("VehiclePassengerCapacity", "Vehicle PassengerCapacity");
            LoadDataToGridView();
        }

        public void LoadDataToGridView()
        {
            dataGridView_trips.Rows.Clear();

            foreach(var trip in Transport.trips)
            {
                if(trip.time!=dateTimePicker1.Value) { continue; }
                dataGridView_trips.Rows.Add(trip.tripId, trip.vehicle.vehicleType, trip.vehicle.name, trip.vehicle.PassengerCapacity);
            }


        }

        private void btn_addTrip_Click(object sender, EventArgs e)
        {
            CompanyTripAdd companyTripAdd =new CompanyTripAdd(company,this);
            companyTripAdd.Show();
            this.Hide();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            if (selectedTrip != null)
            {
                Transport.trips.Remove(selectedTrip);
                LoadDataToGridView();
                lbl_info.Text = "Selected trip has been successfully deleted";
                lbl_info.ForeColor = Color.Green;
            }
            else
            {
                lbl_info.Text = "You did not choose a trip";
                lbl_info.ForeColor = Color.Red;
            }
        }

        private void dataGridView_trips_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected, selectedTripId;
            if (dataGridView_trips.SelectedCells.Count > 0)
            {
                selected = dataGridView_trips.SelectedCells[0].RowIndex;

                if (int.TryParse(dataGridView_trips.Rows[selected].Cells[0].Value.ToString(), out selectedTripId))
                {
                    foreach (var trip in Transport.trips)
                    {
                        if (trip.tripId == selectedTripId) selectedTrip = trip;
                    }
                }
            }
        }

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            companyForm.Show();
            this.Close();
        }
    }
    
    
}
