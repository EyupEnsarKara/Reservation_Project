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

namespace project2_begin.Forms.User
{
    public partial class UserSearchForm : Form
    {
        Route route;
        public UserSearchForm()
        {
            Transport.vehicles.Clear();
            Funcitons.copyVehicleMem();
            InitializeComponent();
            dataGridView_vehicles.Columns.Add("TripId", "Trip Id");

            dataGridView_vehicles.Columns.Add("Company", "Company");
            dataGridView_vehicles.Columns.Add("VehicleName", "Vehicle Name");
            dataGridView_vehicles.Columns.Add("Price","Price");

            dataGridView_vehicles.Columns.Add("AvaibleSeats", "Avaible Seats");
            dataGridView_vehicles.Columns.Add("Deparuture", "Deparuture");
            dataGridView_vehicles.Columns.Add("Destination", "Destination");
        }

        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            Program.mainform.Show();
            this.Close();
        }

        private void comboBox_vehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_deparature.Items.Clear();
            comboBox_destination.Items.Clear();
            foreach (var defaulttrip in defaultTrip.returnroute(comboBox_vehicleType.Text))
            {
                if (comboBox_deparature.Items.Contains(defaulttrip.Deparature)) continue;

                comboBox_deparature.Items.Add(defaulttrip.Deparature);

            }
        }

        private void comboBox_deparature_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_destination.Items.Clear();
            defaultTrip.addList(comboBox_vehicleType.Text);
            foreach (var list in defaultTrip.lists)
            {
                {
                    bool control = false;

                    foreach (var route in list)
                    {
                        if (comboBox_deparature.Text == route.Deparature || control)
                        {
                            control = true;
                            if (comboBox_deparature.Items.Contains(route.Deparature))
                            {
                                if (comboBox_destination.Items.Contains(route.Destination)) continue;
                                if (comboBox_deparature.Text.Equals(route.Destination)) continue;

                                comboBox_destination.Items.Add(route.Destination);
                            }
                        }
                    }

                }
            }
        }

        public void LoadDataToGridView()
        {
            dataGridView_vehicles.Rows.Clear();
            route = new Route(comboBox_deparature.Text, comboBox_destination.Text);

            foreach (var trip in Transport.trips)
            {
                
                if (dateTimePicker1.Value != trip.time) continue;
                if (comboBox_vehicleType.Text != trip.vehicle.vehicleType) continue;
                if(!(trip.emptySeatsCount(trip,route)>=Convert.ToInt32(txtbox_passengerCount.Text))) continue;
                bool control=true;
                for (int i = 0; i< trip.vehicle.PassengerCapacity;i++)
                {
                    if (Program.transport.CheckSeatStatus(i, trip, route)) control = false;
                }
                if(control)  continue; 
                route.CalculateCost(trip);
                if (route.Distance != 0) 
             
                dataGridView_vehicles.Rows.Add(trip.tripId,trip.companyName, trip.vehicle.name,route.price, trip.emptySeatsCount(trip,route), comboBox_deparature.Text, comboBox_destination.Text);
               
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        Trip selectedtrip = null;
        private void btn_continue_Click(object sender, EventArgs e)
        {


            if (selectedtrip == null) return;
           
            BuyTheTicket buyTheTicket =new BuyTheTicket(Convert.ToInt32(txtbox_passengerCount.Text),selectedtrip,route,this);
            buyTheTicket.Show();
            this.Hide();               
        }

        private void dataGridView_vehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected;

            if (dataGridView_vehicles.SelectedCells.Count > 0)
            {
                selected = dataGridView_vehicles.SelectedCells[0].RowIndex;
                foreach(var trip in Transport.trips) {
                if(trip.tripId== Convert.ToInt32(dataGridView_vehicles.Rows[selected].Cells[0].Value))
                    {
                        selectedtrip = trip;
                    }
                }

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView_vehicles.Rows.Clear();
        }       
    }
}
