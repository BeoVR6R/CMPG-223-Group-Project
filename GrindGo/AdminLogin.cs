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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        AdminPanel formAdminPanel = new AdminPanel();

        string masterPassword = "1234";
        int counter = 0;

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_adminLogin_Click(object sender, EventArgs e)
        {
            lbl_Message.Text = "";
            string enteredPassword = txtBx_adminPassword.Text;
            if (string.IsNullOrEmpty(enteredPassword))
                MessageBox.Show("Password is required.");

            if (enteredPassword == masterPassword)
            {
                this.Close();
                formAdminPanel.Show();
            }

            if (enteredPassword != masterPassword)
            {
                if (counter == 2)
                    this.Close();
                MessageBox.Show("You have entered the wrong password.");
                counter++;
            }
        }
    }
}
