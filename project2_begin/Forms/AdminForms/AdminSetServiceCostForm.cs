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
    public partial class AdminSetServiceCostForm : Form
    {   
        private AdminForm adminForm;
        public AdminSetServiceCostForm(AdminForm adminForm)
        {
           this.adminForm = adminForm;
            InitializeComponent();
        }

        private void AdminSetServiceCostForm_Load(object sender, EventArgs e)
        {
            txtbox_serviceCost.Text = Program.admin.getServiceCost().ToString();
        }

        private void btn_setcost_Click(object sender, EventArgs e)
        {

            Program.admin.setServiceServiceCost(txtbox_serviceCost,lbl_info);

        }
        private void btn_adminMenu_Click(object sender, EventArgs e)
        {
            adminForm.Show();
            this.Close();
        }
    }
}
