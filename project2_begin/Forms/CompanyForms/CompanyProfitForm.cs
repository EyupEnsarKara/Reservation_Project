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
    public partial class CompanyProfitForm : Form
    {
        private CompanyForm companyForm;
        private Company company;
        public CompanyProfitForm(CompanyForm companyForm,Company company)
        {
            this.companyForm = companyForm;
            this.company = company;
            InitializeComponent();
        }

        private void btn_calculateDailyProfit_Click(object sender, EventArgs e)
        {
            int profit = company.CalculateDailyProfit(dateTimePicker1.Value);
            lbl_dailyProfit.Text = profit.ToString();
            if (profit > 0 )
            {
                
                lbl_dailyProfit.ForeColor = Color.Green;
            }
            else
            {
                lbl_dailyProfit.ForeColor= Color.Red;
            }
        }

        private void btn_calculateAllProfit_Click(object sender, EventArgs e)
        {
            int profit = company.CalculateOverallProfitLoss();
            lbl_allProfit.Text = profit.ToString();
            if (profit > 0)
            {

                lbl_allProfit.ForeColor = Color.Green;
            }
            else
            {
                lbl_allProfit.ForeColor = Color.Red;
            }
        }

        private void btn_companyMenu_Click(object sender, EventArgs e)
        {
            companyForm.Show();
            this.Close();
        }
    }
}
