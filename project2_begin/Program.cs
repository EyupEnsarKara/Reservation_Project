//220201061 Eyüp Ensar Kara 220201083 Yunus Hanifi Öztürk

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project2_begin.Classes;
using project2_begin.Forms;
namespace project2_begin
{
    internal class Program
    {
           static public Admin admin = new Admin("Username","Password");

           static public Transport transport = new Transport();

        static public MainForm mainform = new MainForm();
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////////
            ///Test Verileri ekleme
            
            Funcitons.generateDefaultCompanies();
            generateRandomTrips();
            ////////////////////////////////////////////////////////////////////
            Application.EnableVisualStyles();
            Application.Run(mainform);
           
           
        }
        static public void generateRandomTrips()
        {
            Random rand = new Random();

            foreach (var trip in Transport.trips)
            {
                
                int max_seatCount = rand.Next(0, trip.passengerCount);
                if ((max_seatCount + 5) < trip.passengerCount) max_seatCount += 5;
                for (int i = 0; i < max_seatCount; i++)
                {
                    int choice = rand.Next(0, max_seatCount);
                    foreach(Route route in trip.sumRoutes())
                    {
                        transport.ReserveSeat(trip, choice, route);
                    }
                    
                }
            }

        }
    }

}
