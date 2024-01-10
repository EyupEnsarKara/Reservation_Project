using project2_begin.Classes;
using project2_begin.Forms.AdminForms;
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
    public partial class AdminForm : Form
    { 
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_viewCompany_Click(object sender, EventArgs e)
        {
          Program.admin.showViewCompanyForm(this);
        }

        private void btn_setServiceCost_Click(object sender, EventArgs e)
        {
            Program.admin.showSetServiceCostForm(this);

        }

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            Program.mainform.Show();
            this.Close();
        }
    }
}
