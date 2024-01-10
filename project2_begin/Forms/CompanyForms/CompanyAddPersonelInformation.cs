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
    public partial class CompanyAddPersonelInformation : Form
    {
        private CompanyVehicleSet companyVehicleSetForm;
        private Vehicle vehicle;
        private Company company;
        private int count = 1;
        public CompanyAddPersonelInformation(CompanyVehicleSet companyVehicleSetForm,Vehicle vehicle,Company company)
        {
            this.companyVehicleSetForm = companyVehicleSetForm;
            this.vehicle = vehicle;
            this.company = company;

            InitializeComponent();
            vehicle.personel.Clear();
            loadForm();
        }
        private void loadForm()
        {
            if (count == 5)
            {
                btn_save.Visible = false;
                btn_vehicleMenu.Visible = true;
                btn_vehicleMenu_Click(null, null);
                return;
            }
            lbl_info.Text=count.ToString()+".Personel Infos";
            txtbox_firstName.Text = string.Empty;
            txtbox_lastName.Text = string.Empty;
            comboBox_role.SelectedIndex = -1;
            
        }



        private void btn_save_Click(object sender, EventArgs e)
        {
            
            vehicle.addPersonelInformation(company, txtbox_firstName.Text, txtbox_lastName.Text, comboBox_role.Text);
            count++;
            loadForm();
        }

        private void btn_vehicleMenu_Click(object sender, EventArgs e)
        {
            companyVehicleSetForm.LoadDataToGridView();
            companyVehicleSetForm.Show();
            this.Close();
        }

  
    }
}
