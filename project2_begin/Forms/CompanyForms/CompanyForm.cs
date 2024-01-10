using project2_begin.Classes;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2_begin.Forms.CompanyForms
{
    public partial class CompanyForm : Form
    {
        Company company;
        public CompanyForm(string username)
        {
            company = getCompanyObject(username);
            InitializeComponent();  
        }

        private Company getCompanyObject(string username)
        {
            foreach (var temp in Transport.Companies)
            {
                if (temp.userName.Equals(username))
                {
                    return temp;
                }
            }
            return null;
        }


        private void CompanyForm_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text += company.companyName;
        }


        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            Program.mainform.Show();
            this.Close();
        }

        private void btn_vehicleSettings_Click(object sender, EventArgs e)
        {
            company.showCompanyVehicleSetForm(this, company);
        }

        private void btn_tripSettings_Click(object sender, EventArgs e)
        {
            company.showCompanyTripset(this, company);
        }

        private void btn_setSalaries_Click(object sender, EventArgs e)
        {
            CompanySetSalariesForm companySetSalariesForm = new CompanySetSalariesForm(company,this);
            companySetSalariesForm.Show();
            this.Hide();
        }

        private void btn_setFuelCosts_Click(object sender, EventArgs e)
        {
            CompanySetFuelCosts companySetFuelCosts = new CompanySetFuelCosts(company,this);
            companySetFuelCosts.Show();
            this.Hide();
        }

        private void btn_calculateDailyProfit_Click(object sender, EventArgs e)
        {
            CompanyProfitForm companyProfitForm = new CompanyProfitForm(this,company);
            companyProfitForm.Show();
            this.Hide();
        }
    }
}
