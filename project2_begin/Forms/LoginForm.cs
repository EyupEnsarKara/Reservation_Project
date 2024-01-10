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
using project2_begin.Forms.AdminForms;
using project2_begin.Forms.CompanyForms;

namespace project2_begin.Forms
{
    public partial class LoginForm : Form
    {
        private string control;
        public LoginForm(string logged)
        {
            InitializeComponent();
            control = logged;
            if (control == "admin")
            {
                this.Text = "Admin Login";
                lbl_loginInfo.Text = "Admin Login";
            }
            else if(control == "company")
            {
                this.Text = "Company Login";
                lbl_loginInfo.Text = "Company Login";
            }
           
        }
 
        
        public void btn_login_Click(object sender, EventArgs e)
        {
            
            Program.admin.Login(control, txtbox_username.Text, txtbox_password.Text, lbl_info, this);

        }

        private void txtbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                this.btn_login_Click(sender, e);
            }
        }

        private void txtbox_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                this.btn_login_Click(sender, e);
            }
        }

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            Program.mainform.Show();
            this.Close();
        }

        private void txtbox_username_Enter(object sender, EventArgs e)
        {
            if(txtbox_username.Text == "Username")
            {
                txtbox_username.Text = "";
                txtbox_username.ForeColor = Color.Black;
            }
        }

        private void txtbox_username_Leave(object sender, EventArgs e)
        {
            if (txtbox_username.Text == "")
            {
                txtbox_username.Text = "Username";
                txtbox_username.ForeColor = Color.Silver;
            }
        }

        private void txtbox_password_Enter(object sender, EventArgs e)
        {
            if (txtbox_password.Text == "Password")
            {
                txtbox_password.Text = "";
                txtbox_password.ForeColor = Color.Black;
            }
        }

        private void txtbox_password_Leave(object sender, EventArgs e)
        {
            if(txtbox_password.Text == "")
            {
                txtbox_password.Text= "Password";
                txtbox_password.ForeColor= Color.Silver;
            }
        }
    }
}
