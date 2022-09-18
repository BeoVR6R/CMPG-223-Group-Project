using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrindGo
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GrindGo;Data Source=BEO-PC\SQLEXPRESS");

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {

            string firstName = txtBx_firstName.Text;
            string lastName = txtBx_lastName.Text;
            string address = txtBx_Address.Text;
            string emailAddress = txtBx_emailAddress.Text;
            string password = txtBx_Password.Text;


            if (txtBx_firstName.Text.Length == 0 || txtBx_lastName.Text.Length == 0 || txtBx_Address.Text.Length == 0 || txtBx_emailAddress.Text.Length == 0 || txtBx_Password.Text.Length == 0)
            {
                MessageBox.Show("Error. All fields are required");
            }
            else if (IsValidEmail(emailAddress) == false)
            {
                MessageBox.Show("Please enter a valid email address.");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO adminClass.CUSTOMER VALUES (" + "'" +  firstName + "'" + "," + "'" + lastName + "'" + "," + "'" + address + "'" + "," + "'" + emailAddress + "'" + "," +
                        "'" + password + "'" + "," + 0 + ");";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandTimeout = 60;
                    cmd.CommandText = query;

                    conn.Open();
                    cmd.ExecuteScalar();

                    MessageBox.Show("Operation Completed Successfully.");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Error has occured.");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
