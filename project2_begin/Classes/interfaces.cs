using project2_begin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2_begin.Classes
{

    public interface ILoginable
    {
       void Login(string formType, string username, string password, Label lbl_info, LoginForm loginForm);          
    }


    public interface IReservable
    {
        bool CheckSeatStatus(int seat, Trip trip,Route route); 
        void ReserveSeat(Trip trip, int seatNo, Passenger passenger, Route route);
    }

    public interface IProfitable
    {
        int CalculateDailyProfit(DateTime time);
        int CalculateOverallProfitLoss();
    }

}
