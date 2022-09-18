using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrindGo
{
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=BEO-PC\SQLEXPRESS;Initial Catalog=GrindGo;Integrated Security=True");
        int customerId = 0; 

        private void btn_updateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateCustomerInfo();
                MessageBox.Show("Customer updated successfully.");
                this.Close();   
            }
            catch
            {
                MessageBox.Show("Error, no changes have been made");
            }
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
           /* txtBx_C__edit_firstName.Text = "";
            txtBx_C__edit_lastName.Text = "";
            txtBx_C__edit_address.Text = "";
            txtBx_C__edit_emailAddress.Text = "";
            txtBx_C__edit_password.Text = "";*/
        }

        public void LoadCustomerInfo(string firstName, string lastName, string residentialAddress, string emailAddress, string password)
        {
            try
            {
                txtBx_C__edit_firstName.Text = firstName;
                txtBx_C__edit_lastName.Text = lastName; 
                txtBx_C__edit_address.Text = residentialAddress;
                txtBx_C__edit_emailAddress.Text = emailAddress;
                txtBx_C__edit_password.Text = password; 
                
            }
            catch
            {
                MessageBox.Show("ERROR loading data.");
            }
        }

        private void UpdateCustomerInfo()
        {
            try
            {
                string query = "UPDATE adminClass.CUSTOMER SET firstName = '" + txtBx_C__edit_firstName.Text + "', lastName = '" + txtBx_C__edit_lastName.Text + "', residentialAddress = '" + txtBx_C__edit_address.Text + "', emailAddress = '" + txtBx_C__edit_emailAddress.Text + "', password = '" + txtBx_C__edit_password.Text + "' WHERE customerID = " + customerId +";";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 60;
                cmd.CommandText = query;

                conn.Open();
                cmd.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("Error, no changes have been made");
            }
            finally
            {
                conn.Close();
            }
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
    }
}
