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
    public partial class CompanySetSalariesForm : Form
    {
        private Company company;
        private CompanyForm companyForm;
        public CompanySetSalariesForm(Company company, CompanyForm companyForm)
        {
            this.companyForm = companyForm;
            this.company = company;

            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            txtbox_busDriverSalary.Text=company.driverSalaries.busSalary.ToString();
            txtbox_busHelperSalary.Text=company.helperSalaries.busSalary.ToString();
            txtbox_trainDriverSalary.Text=company.driverSalaries.trainSalary.ToString();
            txtbox_trainHelperSalary.Text=company.helperSalaries.trainSalary.ToString();
            txtbox_airplaneDriverSalary.Text=company.driverSalaries.airplaneSalary.ToString();
            txtbox_airplaneHelperSalary.Text=company.helperSalaries.airplaneSalary.ToString();
            lbl_info.Text = string.Empty;
        }

        private void btn_setSalaries_Click(object sender, EventArgs e)
        {
            int busDriverSalary,busHelperSalary,trainDriverSalary,trainHelperSalary,airplaneDriverSalary,airplaneHelperSalary;
            if(!(int.TryParse(txtbox_busDriverSalary.Text,out busDriverSalary)&&int.TryParse(txtbox_busHelperSalary.Text,out busHelperSalary)&&busDriverSalary>0&&busHelperSalary>0))
            {
                lbl_info.Text = "Bus staff fares must be a number greater than 0";
                lbl_info.ForeColor = Color.Red;
                return;
            }
            if(!(int.TryParse(txtbox_trainDriverSalary.Text,out trainDriverSalary)&&int.TryParse(txtbox_trainHelperSalary.Text,out trainHelperSalary)&&trainDriverSalary>0&&trainHelperSalary>0))
            {
                lbl_info.Text = "Train staff wages must be a number greater than 0";
                lbl_info.ForeColor = Color.Red;
                return;
            }
            if (!(int.TryParse(txtbox_airplaneDriverSalary.Text, out airplaneDriverSalary) && int.TryParse(txtbox_airplaneHelperSalary.Text, out airplaneHelperSalary) && airplaneDriverSalary > 0 && airplaneHelperSalary > 0))
            {
                lbl_info.Text = "Aircraft staff wages must be a number greater than 0";
                lbl_info.ForeColor = Color.Red;
                return;
            }
            company.driverSalaries=new Salaries(busDriverSalary, trainDriverSalary, airplaneDriverSalary);
            company.helperSalaries=new Salaries(busHelperSalary, trainHelperSalary, airplaneHelperSalary);
            lbl_info.Text = "Costs assigned.";
            lbl_info.ForeColor = Color.Teal;
        }

        private void btn_companyForm_Click(object sender, EventArgs e)
        {
            companyForm.Show();
            this.Close();
        }

        private void txtbox_Salary_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;
            }
        }

        private void txtbox_Salary_Leave(object sender, EventArgs e)
        {
            TextBox textBox2 = sender as TextBox;
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
        }
    }
}
