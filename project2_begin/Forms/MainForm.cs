using project2_begin.Classes;
using project2_begin.Forms.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2_begin.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LoginForm adminlogin = new LoginForm("admin");
            adminlogin.Show();
            this.Hide();

        }

        private void btn_company_Click(object sender, EventArgs e)
        {
            LoginForm companyLogin = new LoginForm("company");
            companyLogin.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            UserSearchForm searchForm = new UserSearchForm();
            searchForm.Show();
            this.Hide();
        }
    }
}
