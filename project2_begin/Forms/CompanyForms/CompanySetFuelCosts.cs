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
    public partial class CompanySetFuelCosts : Form
    {
        private Company company;
        private CompanyForm companyForm;
        public CompanySetFuelCosts(Company company,CompanyForm companyForm)
        {
            this.companyForm = companyForm;
            this.company = company;
            InitializeComponent();
            lbl_info.Text=string.Empty;
            loadForm();
        }
        public void setLbl_info(string str)
        {
            lbl_info.Text = str;
            lbl_info.ForeColor = Color.Teal;
        }
        private void loadForm()
        {
            txtbox_motorine.Text = company.motorinePrice.ToString();
            txtbox_gasoline.Text = company.gasolinePrice.ToString();
            txtbox_electric.Text = company.electricPrice.ToString();
            txtbox_gas.Text = company.gasPrice.ToString();
        }
        



        private int convertTextboxToInt(TextBox textbox)
        {
            int value;
            if(int.TryParse(textbox.Text,out value))
            {
                return value;
            }
            lbl_info.Text = "Enter a valid number value";
            lbl_info.ForeColor = Color.Red;
            textbox.Text = string.Empty;
            return 0;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (convertTextboxToInt(txtbox_motorine) > 0 && convertTextboxToInt(txtbox_gasoline) > 0 && convertTextboxToInt(txtbox_electric) > 0 && convertTextboxToInt(txtbox_gas) > 0)
            {
                company.motorinePrice = convertTextboxToInt(txtbox_motorine);
                company.gasolinePrice = convertTextboxToInt(txtbox_gasoline);
                company.electricPrice = convertTextboxToInt(txtbox_electric);
                company.gasPrice = convertTextboxToInt(txtbox_gas);
                lbl_info.Text = "Prices setted";
                lbl_info.ForeColor = Color.Green;
                companyForm.Show();
                this.Close();
            }
            else
            {
                lbl_info.Text = "Price cannot be less than 0";
                lbl_info.ForeColor = Color.Red;
            }
        }
    }
}
