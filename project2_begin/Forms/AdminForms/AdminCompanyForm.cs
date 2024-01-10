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

namespace project2_begin.Forms.AdminForms
{ 
  public partial class AdminCompanyForm : Form
    {

        private AdminForm adminForm;
        public AdminCompanyForm(AdminForm adminForm)
        {
            this.adminForm = adminForm;
            InitializeComponent();

            dataGridView1.Columns.Add("CompanyName", "Company Name");
            dataGridView1.Columns.Add("UserName", "User Name");
            dataGridView1.Columns.Add("Password", "Password");        
            LoadDataToDataGridView();

        }


        private void LoadDataToDataGridView()
        {
        
            dataGridView1.Rows.Clear();

            foreach (var company in Transport.Companies)
            {
                dataGridView1.Rows.Add(company.companyName,company.userName, company.password);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //bilgilerin boşluk kontrolü
           if(txtbox_companyName.Text==string.Empty||txtbox_password.Text==string.Empty||txtbox_username.Text==string.Empty)
            {
                lbl_info.Text = "You entered incomplete information";
                lbl_info.ForeColor = Color.Red;
                return;
            }
            //Aynı kullanıcı kontrolü
            bool control = false;
           foreach(Company temp in Transport.Companies)
            {
                if (temp.companyName == txtbox_companyName.Text || temp.userName == txtbox_username.Text)
                {
                    control = true;
                }
            }

            if (!control)
            {
                int driverSalary,helperSalary;

                Program.admin.addCompany(new Company(txtbox_companyName.Text,txtbox_username.Text, txtbox_password.Text));
                LoadDataToDataGridView();
                lbl_info.Text = "User added successfully.";
                lbl_info.ForeColor = Color.Green;
            }
            else
            {
                lbl_info.Text = "User information cannot be the same.";
                lbl_info.ForeColor = Color.Red;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtbox_companyName.Text= string.Empty;
            txtbox_username.Text = string.Empty;
            txtbox_password.Text= string.Empty;
            lbl_info.Text= string.Empty;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool control =Program.admin.deleteCompany(txtbox_companyName);

            if (control)
            {
                txtbox_companyName.Text = string.Empty;
                txtbox_username.Text = string.Empty;
                txtbox_password.Text = string.Empty;
                lbl_info.Text = "User successfully deleted";
                lbl_info.ForeColor = Color.Teal;
                LoadDataToDataGridView();
            }
            else
            {
                lbl_info.Text = "User information not found";
                lbl_info.ForeColor = Color.Red;
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                selected = dataGridView1.SelectedCells[0].RowIndex;
                txtbox_companyName.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
                txtbox_username.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
                txtbox_password.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            }
    
        }

        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            Program.mainform.Show();
            this.Close();
        }

        private void btn_adminMenu_Click(object sender, EventArgs e)
        {
            adminForm.Show();
            this.Close();
        }
    }
}
