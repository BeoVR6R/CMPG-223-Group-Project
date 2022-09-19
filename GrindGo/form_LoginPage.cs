using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace GrindGo
{
    public partial class form_LoginPage : Form
    {
        public form_LoginPage()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=BEO-PC\SQLEXPRESS;Initial Catalog=GrindGo;Integrated Security=True");
        int customerId = 0;
        string emailAddress;
        string password;
        string firstName;
        bool loginStatus;

        private void lbl_Welcome_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBx_Email.Clear();
            txtBx_Password.Clear();
        }

        private void btn_DevLogin_Click(object sender, EventArgs e)
        {
            form_Homepage formHome = new form_Homepage();
            formHome.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtBx_Email.Text == "" && txtBx_Password.Text == "")
            {
                MessageBox.Show("Email address and password is required.");
            }
            else
            {
                emailAddress = txtBx_Email.Text;
                password = txtBx_Password.Text;
                ValidateLogin(emailAddress, password);
            }
        }

        private void btn_needHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is our user login page.\n\n" +
                "Here you can use your email address and password to log in." +
                "\nIf you do not have an account with us, click on the register button to create one." +
                "\n\nOr you can log in anonymously, loyalty points do not apply.");
        }

        private void GetCustomerID(string emailAddress)
        {
            try
            {
                string query = "SELECT customerID FROM adminClass.CUSTOMER WHERE emailAddress = '" + emailAddress + "';";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 60;
                cmd.CommandText = query;

                conn.Open();
                customerId = (int)cmd.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("Failed to retrieve Customer ID.");
            }
            finally
            {
                conn.Close();
            }
        }

        private void ValidateLogin(string emailAddress, string password)
        {
            GetCustomerID(emailAddress);

            if (customerId == 0)
            {
                MessageBox.Show("User does not exist. Please register an account.");
            }
            else
            {
                string query = "SELECT password FROM adminClass.CUSTOMER WHERE customerID = '" + customerId + "';";
                GetPassword(query);

                if (this.password == password)
                {
                    GetFirstName();
                    MessageBox.Show("Login Successful.\n\n" +
                        "Welcome, " + firstName);
                }
                else
                {
                    MessageBox.Show("Incorrect Password.");
                }
            }
        }

        private void GetPassword(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 60;
                cmd.CommandText = query;

                conn.Open();
                password = (string)cmd.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("Error retrieving password.");
            }
            finally { conn.Close(); }
        }

        private void GetFirstName()
        {
            try
            {
                string query = "SELECT firstName FROM adminClass.CUSTOMER WHERE customerID = '" + customerId + "';";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 60;
                cmd.CommandText = query;

                conn.Open();
                firstName = (string)cmd.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("Error retrieving firstName.");
            }
            finally { conn.Close(); }
        }
    }
}
