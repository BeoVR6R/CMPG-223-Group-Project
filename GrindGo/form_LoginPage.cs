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
        bool loginStatus = false;

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
            else if (txtBx_Email.Text == "")
            {
                MessageBox.Show("Email address is required.");
            }
            else if (txtBx_Password.Text == "")
            {
                MessageBox.Show("Password is required.");
            }
            else if (!IsValidEmail(txtBx_Email.Text))
            {
                MessageBox.Show("A Valid Email address is required.");
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

        public bool GetCustomerID(string emailAddress)
        {
            try
            {
                string query = "SELECT customer_ID FROM adminClass.CUSTOMER WHERE emailAddress = '" + emailAddress + "';";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 60;
                cmd.CommandText = query;

                conn.Open();
                
               
                var returnVal = cmd.ExecuteScalar();
                
                if (returnVal == null)
                {
                    MessageBox.Show("Error, user not found.\n\n" +
                        "Please click on the register new user.");
                    return false;
                }
                else
                {
                    customerId = Convert.ToInt32(returnVal);
                    return true;
                }
               
            }
            catch
            {
                MessageBox.Show("Failed to retrieve Customer ID.");
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void ValidateLogin(string emailAddress, string password)
        {
            loginStatus = GetCustomerID(emailAddress);

            if (loginStatus)
            {
                string query = "SELECT c_password FROM adminClass.CUSTOMER WHERE customer_ID = '" + customerId + "';";
                if (txtBx_Password.Text != "")
                {
                    GetPassword(query);

                    if (this.password == password)
                    {
                        GetFirstName();
                        MessageBox.Show("Login Successful.\n\n" +
                           "Welcome, " + firstName);
                        loginStatus = true;

                        form_Homepage formHome = new form_Homepage();
                        formHome.Show();

                        formHome.LoadCustomerInfo(customerId, emailAddress);

                        this.Hide();
                    }
                    else if (this.password != password)
                    {
                        MessageBox.Show("Incorrect Password.1");
                    }
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
                string query = "SELECT firstName FROM adminClass.CUSTOMER WHERE customer_ID = '" + customerId + "';";
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

        private void btn_login_createAccount_Click(object sender, EventArgs e)
        {
            AddCustomer formAddCustomer = new AddCustomer();
            formAddCustomer.Show();
            this.Hide();
        }

        private void form_LoginPage_Load(object sender, EventArgs e)
        {
            txtBx_Email.Clear();
            txtBx_Password.Clear();
        }

        private void btn_aboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GrindGo - Coffee" +
                "\n\nNeed assistance?" +
                "\nsupport@grindgo.co.za" +
                "\n\nMake a suggestion?" +
                "\nsuggestions@grindgo.co.za");
        }
    }
}
