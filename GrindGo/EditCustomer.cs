﻿using System;
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

        SqlConnection conn = new SqlConnection(form_LoginPage.path);
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
            txtBx_C__edit_firstName.Text = "";
            txtBx_C__edit_lastName.Text = "";
            txtBx_C__edit_address.Text = "";
            txtBx_C__edit_emailAddress.Text = "";
            txtBx_C__edit_password.Text = "";
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

                GetCustomerID(emailAddress);

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

                string query = "UPDATE adminClass.CUSTOMER SET firstName = '" + txtBx_C__edit_firstName.Text + "', lastName = '" + txtBx_C__edit_lastName.Text + "', " +
                    "residentAddress = '" + txtBx_C__edit_address.Text + "', emailAddress = '" + txtBx_C__edit_emailAddress.Text + "', c_password = '"
                    + txtBx_C__edit_password.Text + "' WHERE customer_ID = " + customerId + ";";

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
                string query = "SELECT customer_ID FROM adminClass.CUSTOMER WHERE emailAddress = '" + emailAddress + "';";

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
    }
}
