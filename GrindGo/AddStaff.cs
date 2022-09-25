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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(form_LoginPage.path);

        private void btn_add_c_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addStaff_Click(object sender, EventArgs e)
        {
            Int64 idNumber;
            string firstName, lastName, username, password, residentAddress, dateOfBirth;
            if (txtBx_S_stafffirstName.Text == "" || txtBx_S_stafflastName.Text == "" || txtBx_S_staff_IDNum.Text == "" || txtBx_S_staff_residentAddress.Text == "" || txtBx_S_staff_username.Text == "" || txtBx_S_staff_password.Text == "" || txtBx_S_staff_confirmPassword.Text == "")
            {
                MessageBox.Show("All fields are required.");
            }
            else if (txtBx_S_staff_IDNum.Text.Length != 13)
            {
                MessageBox.Show("Please enter a valid Identification Number.");
            }
            else if (txtBx_S_staff_password.Text != txtBx_S_staff_confirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
            }
            else if (Int64.TryParse(txtBx_S_staff_IDNum.Text, out idNumber))
            {
                firstName = txtBx_S_stafffirstName.Text;
                lastName = txtBx_S_stafflastName.Text;
                username = txtBx_S_staff_username.Text;
                password = txtBx_S_staff_password.Text;
                residentAddress = txtBx_S_staff_residentAddress.Text;
                dateOfBirth = dateTimePicker_staff_add.Value.ToString("yyyy/MM/dd");

                DialogResult dialogResult = MessageBox.Show("Staff : " + firstName + ", " + lastName + "\nUsername : " + username + "\nDate of Birth : " + dateOfBirth + "\nResidential Address : " + residentAddress + "\nIdentification Number : " + idNumber + "\n\nWill be added." +
                "\n\nAre you sure?", "ALERT", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AddStaffMember(firstName, lastName, idNumber, dateOfBirth, residentAddress, username, password);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("No changes have been made.");
                }
            }
            else
            {
                MessageBox.Show("Field Idetification Number is not a number.");
            }
        }

        private void AddStaffMember(string fname, string lname, Int64 idnum, string dob, string residentaddress, string usern, string pass)
        {
            try
            {
                string query = "INSERT INTO adminClass.STAFF VALUES ('" + fname + "', '" + lname + "', '" + idnum + "', '" + dob + "', '" + residentaddress
                    + "', '" + usern + "', '" + pass + "');";

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
                MessageBox.Show("Error adding item into STAFF.");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
