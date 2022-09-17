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

        string masterPassword = "1234";
        int counter = 0;  

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_adminLogin_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtBx_adminPassword.Text;
            if (string.IsNullOrEmpty(enteredPassword))
                lbl_Message.Text = "Value is required!";

            if (enteredPassword == masterPassword)
            {
                this.Close();
                AdminPanel formAdminPanel = new AdminPanel();
                formAdminPanel.Show();
            }

            if (enteredPassword != masterPassword)
            {
                if (counter == 2)
                    this.Close();
                lbl_Message.Text = "You have entered the wrong password.";
                counter++;
            }
        }
    }
}
