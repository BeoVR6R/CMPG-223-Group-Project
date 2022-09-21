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

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_maintainCustomers_Click(object sender, EventArgs e)
        {
            this.Close();
            MaintainCustomers formMaintainCustomers = new MaintainCustomers();
            formMaintainCustomers.Show();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPanel_Reports form_admin_reports = new AdminPanel_Reports();
            form_admin_reports.Show();  
        }

        private void lbl_adminPanel_Maintain_Click(object sender, EventArgs e)
        {

        }
    }
}
