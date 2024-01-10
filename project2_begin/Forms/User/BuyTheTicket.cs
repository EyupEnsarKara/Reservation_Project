using project2_begin.Classes;
using project2_begin.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace project2_begin.Forms.User
{
    public partial class BuyTheTicket : Form
    {
        private int passangerCount;
        private Trip trip;
        private Route passengerRoute;
        private int tempcount = 1;
        private UserSearchForm userSearchForm;
        private int selectedSeatSpace = 0;
        private List<List<Button>> buttons = new List<List<Button>>();
        public BuyTheTicket(int passangerCount, Trip trip, Route passengerRoute, UserSearchForm userSearchForm)
        {
            //private değişken tanımlama
            this.trip = trip;           
            this.passangerCount = passangerCount;
            this.passengerRoute = passengerRoute;
            this.userSearchForm = userSearchForm;



            InitializeComponent();
            if (passangerCount == 1)
            {
                btn_continue.Visible = false;

                btn_finish.Visible = true;
            }
            if(trip.vehicle.PassengerCapacity > 40) {
            
            btn_next.Visible = true;
            }
            loadPassangerForm();
            Console.WriteLine(passengerRoute.price);
        }

        private void loadPassangerForm()
        {
            lbl_vehicleType.Text = trip.vehicle.vehicleType;
          
            lbl_deparature.Text = passengerRoute.Deparature;
            lbl_destination.Text = passengerRoute.Destination;
            lbl_date.Text = trip.time.ToString();
            lbl_passangerinfo.Text = tempcount.ToString() + ". passenger information";
            lbl_info.Text = string.Empty;
            if (passangerCount == tempcount)
            {
                btn_continue.Visible = false;

                btn_finish.Visible = true;
            }
            txtbox_name.Text = string.Empty;
            txtbox_selectedSeat.Text = string.Empty;
            txtbox_surname.Text = string.Empty;
            maskedTextBox_bornDate.Text = string.Empty;
            maskedTextBox_tc.Text = string.Empty;
            generateSeatButtons(trip.vehicle.PassengerCapacity, 40 * selectedSeatSpace + 1);
            if (trip.vehicle.PassengerCapacity > 40) btn_next.Visible = true;

        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            int selectedSeat;
            if (!int.TryParse(txtbox_selectedSeat.Text, out selectedSeat))
            {
                lbl_info.Text = "Selected seat number is not avaible";
                lbl_info.ForeColor = Color.Red;
            }
            if (!Program.transport.CheckSeatStatus(selectedSeat - 1, trip, passengerRoute))
            {
                lbl_info.Text = "Selected Seat is not empty";
                lbl_info.ForeColor = Color.Teal;
                return;
            }
            generateSeatButtons(trip.vehicle.PassengerCapacity, 40 * selectedSeatSpace + 1);

            Passenger passenger = new Passenger(txtbox_name.Text, txtbox_surname.Text, maskedTextBox_tc.Text, DateTime.Parse(maskedTextBox_bornDate.Text.ToString()), passengerRoute);
            Program.transport.ReserveSeat(trip, Convert.ToInt32(txtbox_selectedSeat.Text)-1, passenger, passengerRoute);
            tempcount++;
            removeButtons();
            loadPassangerForm();


        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            int selectedSeat;
            if (!int.TryParse(txtbox_selectedSeat.Text, out selectedSeat))
            {
                lbl_info.Text = "Selected seat number is not avaible";
                lbl_info.ForeColor = Color.Red;
                return;
            }
            if (!Program.transport.CheckSeatStatus(selectedSeat - 1, trip, passengerRoute))
            {
                lbl_info.Text = "Selected Seat is not empty";
                lbl_info.ForeColor = Color.Teal;
                return;
            }
            Passenger passenger = new Passenger(txtbox_name.Text, txtbox_surname.Text, maskedTextBox_tc.Text, DateTime.Parse(maskedTextBox_bornDate.Text.ToString()), passengerRoute);
            Program.transport.ReserveSeat(trip, selectedSeat-1, passenger, passengerRoute);
            userSearchForm.LoadDataToGridView();
            userSearchForm.LoadDataToGridView();
            userSearchForm.Show();
            this.Close();
        }

        private void btn_testAcsess_Click(object sender, EventArgs e)
        {
            txtbox_name.Text = "test";
            txtbox_surname.Text = "test";
            maskedTextBox_bornDate.Text = "11/11/1111";
            maskedTextBox_tc.Text = "11111111111";
        }
        public void removeButtons()
        {
            foreach (var list in buttons)
            {
                foreach (var item in list)
                {

                    Controls.Remove(item);
                }
            }
            buttons.Clear();
        }
        GroupBox groupBox_info = new GroupBox();
        public void generateSeatButtons(int vehicleCapacity, int count)
        {
            Controls.Remove(groupBox_info);
            int maxSeatCount = vehicleCapacity / 4;

            
            int top = 450;
            int left = 55;
            
            for (int i = 0; i < 10; i++)
            {
                buttons.Add(new List<Button>());
                for (int j = 0; j < 4; j++)
                {
                    if (count > trip.vehicle.PassengerCapacity) break;

                    buttons[i].Add(new Button());
                    buttons[i][j].Size = new System.Drawing.Size(40, 40);
                    buttons[i][j].Location = new System.Drawing.Point(top, left);
                    buttons[i][j].BackgroundImage = Resources.Empy_Seat;
                    if (!Program.transport.CheckSeatStatus(count-1, trip, passengerRoute))
                    {


                        buttons[i][j].FlatAppearance.BorderColor = Color.LightGreen;
                        buttons[i][j].BackgroundImage = Resources.full_seat_selection;


                    }
                    buttons[i][j].BackColor = System.Drawing.SystemColors.ActiveCaption;
                    buttons[i][j].BackgroundImageLayout = ImageLayout.Stretch;
                    buttons[i][j].TextAlign = ContentAlignment.TopLeft;
                    //set click event
                    buttons[i][j].Click += new EventHandler(seat_Click);
                    left += 50;

                   
                    buttons[i][j].FlatStyle = FlatStyle.Flat;
                    buttons[i][j].FlatAppearance.BorderSize = 0;
                    buttons[i][j].Font = new Font(buttons[i][j].Font.FontFamily, 12);
                    buttons[i][j].Text = (count).ToString();
                    count++;
                    Controls.Add(buttons[i][j]);
                }
                top += 50;
                left = 55;
                
            }
           
            groupBox_info.BackColor = System.Drawing.SystemColors.ActiveCaption;
            groupBox_info.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox_info.Location = new System.Drawing.Point(400, 20);
            groupBox_info.Name = "groupBox_info";
            groupBox_info.Size = new System.Drawing.Size(550, 250);
            groupBox_info.TabIndex = 62;
            groupBox_info.TabStop = false;
            groupBox_info.Text = lbl_vehicleType.Text;
            Controls.Add (groupBox_info);


        }
        private void seat_Click(object sender, EventArgs e)
        {
            Button seat = (Button)sender;

            if (!Program.transport.CheckSeatStatus(Convert.ToInt32(seat.Text)-1, trip, passengerRoute))
            {
                lbl_info.Text = "Selected Seat is not empty";
                lbl_info.ForeColor = Color.Teal;
                return;
            }


            txtbox_selectedSeat.Text = seat.Text;
        }   



        private void btn_next_Click(object sender, EventArgs e)
        {
            selectedSeatSpace++;
            removeButtons();

            generateSeatButtons(trip.vehicle.PassengerCapacity, 40 * selectedSeatSpace + 1);

            if (trip.vehicle.PassengerCapacity > 40) btn_next.Visible = true;
            btn_priv.Visible = true;
            if((selectedSeatSpace+1)*40 > trip.vehicle.PassengerCapacity)btn_next.Visible = false;
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {
            selectedSeatSpace--;
            removeButtons();

            generateSeatButtons(trip.vehicle.PassengerCapacity, 40 * selectedSeatSpace + 1);

            if (trip.vehicle.PassengerCapacity > 40) btn_next.Visible = true;
            if (selectedSeatSpace == 0)
            {
                btn_priv.Visible = false;

            }
        }
    }
}
