using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrindGo
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        MaintainCustomers formMaintainCustomers = new MaintainCustomers();
        AdminPanel_Reports form_admin_reports = new AdminPanel_Reports();
        MaintainStock form_maintainStock = new MaintainStock();
        MaintainStaff form_maintainStaff = new MaintainStaff();

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_maintainCustomers_Click(object sender, EventArgs e)
        {
            this.Close();
            formMaintainCustomers.Show();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            this.Close();
            form_admin_reports.Show();  
        }

        private void lbl_adminPanel_Maintain_Click(object sender, EventArgs e)
        {

        }

        private void btn_maintainConsumables_Click(object sender, EventArgs e)
        {
            this.Close();
            form_maintainStock.Show();
        }

        private void btn_maintainStaff_Click(object sender, EventArgs e)
        {
            this.Close();
            form_maintainStaff.Show();
        }
    }
}
