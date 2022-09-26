using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GrindGo
{
    public partial class AdminPanel_Reports : Form
    {
        public AdminPanel_Reports()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(form_LoginPage.path);

        int search;
        int customerID = 0;
        int staffID = 0;
        int countOrders;

        private void AdminPanel_Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grindGoDataSet3.ORDERS' table. You can move, or remove it, as needed.
            this.oRDERSTableAdapter.Fill(this.grindGoDataSet3.ORDERS);

            chkBx_order_ID.Checked = false;
            order_include_c_details.Checked = false;
            chkBx_order_staffDetails.Checked = false;
            chkBx_order_Date.Checked = false;
            chkBx_order_count.Checked = false;
            txtBx_SearchID.Text = "";

            txtBx_SearchID.Visible = false;
            btn_order_search.Visible = false;
            btn_order_findID.Visible = false;

            lbl_datePicker.Visible = false;
            dateTimePicker_from.Visible = false;
            dateTimePicker_to.Visible = false;
            btn_order_date_search.Visible = false;
        }

        private void btn_refreshTable_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand c = new SqlCommand("SELECT order_ID, order_Time, order_Date, order_Total, staff_ID, customer_ID FROM adminClass.ORDERS", conn);
            SqlDataAdapter sda = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            txtBx_SearchID.Text = "";
            chkBx_order_ID.Checked = false;
            order_include_c_details.Checked = false;
            chkBx_order_staffDetails.Checked = false;
            chkBx_order_Date.Checked = false;
            chkBx_order_count.Checked = false;

            txtBx_SearchID.Visible = false;
            btn_order_search.Visible = false;
            btn_order_findID.Visible = false;


            lbl_datePicker.Visible = false;
            dateTimePicker_from.Visible = false;
            dateTimePicker_to.Visible = false;
            btn_order_date_search.Visible = false;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_order_search_Click(object sender, EventArgs e)
        {
            if (txtBx_SearchID.Text == "")
            {
                MessageBox.Show("Please enter a search field.");
            }
            else
            {
                try
                {
                    if (int.TryParse(txtBx_SearchID.Text, out search))
                    {
                        conn.Open();
                        SqlCommand c = new SqlCommand("SELECT order_ID, order_Time, order_Date, order_Total, staff_ID, customer_ID" +
                            " FROM adminCLass.ORDERS WHERE order_ID = " + search + ";", conn);
                        SqlDataAdapter sda = new SqlDataAdapter(c);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;

                        if (order_include_c_details.Checked == true)
                        {
                            GetCustomerDetails();
                        }

                        if (chkBx_order_staffDetails.Checked == true)
                        {
                            GetStaffDetails();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error. Enter a correct numerical value.");
                    }
                }
                catch
                {
                    MessageBox.Show("Error. Order ID not found");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btn_order_date_search_Click(object sender, EventArgs e)
        {
            string dateFrom = "";
            string dateTo = "";

            dateFrom = dateTimePicker_from.Value.ToString("yyyy/MM/dd");
            dateTo = dateTimePicker_to.Value.ToString("yyyy/MM/dd");

            string query = "SELECT order_ID, order_Date, order_Time, order_Total, staff_ID, customer_ID FROM adminClass.ORDERS WHERE " +
                "order_Date BETWEEN '" + dateFrom + "' AND '" + dateTo + "';";

            try
            {
                conn.Open();
                SqlCommand c = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                if (chkBx_order_count.Checked == true)
                {
                    countOrders = CountOrders(dateFrom, dateTo);

                    if (countOrders > 0)
                    {
                        MessageBox.Show("Total Orders are : " + countOrders);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error. Retrieving ORDERS from dates selected.");
            }
            finally
            {
                conn.Close();
            }
        }

        private int CountOrders(string dateFrom, string dateTo)
        {
            int returnval = 0;
            try
            {
                SqlCommand command = new SqlCommand("SELECT COUNT(order_ID) FROM adminClass.ORDERS WHERE " +
                    "order_Date BETWEEN '" + dateFrom + "' AND '" + dateTo + "';", conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (!reader.IsDBNull(0))
                    {
                        returnval = reader.GetInt32(0);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Failed to count orders");
            }
            finally
            {
                conn.Close();
            }
            return returnval;
        }

        private void chkBx_order_staffDetails_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void order_include_c_details_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBx_order_Date_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBx_order_ID.Checked == true)
            {
                chkBx_order_Date.Checked = false;
                chkBx_order_count.Checked = false;
            }
            else
            {
                lbl_datePicker.Visible = true;
                dateTimePicker_from.Visible = true;
                dateTimePicker_to.Visible = true;
                btn_order_date_search.Visible = true;

                txtBx_SearchID.Visible = false;
                btn_order_search.Visible = false;
                btn_order_findID.Visible = false;
            }
        }

        private void chkBx_order_count_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBx_order_Date.Checked == true)
            {
                chkBx_order_ID.Checked = false;
                chkBx_order_staffDetails.Checked = false;
                order_include_c_details.Checked = false;
            }
            else
            {
                txtBx_SearchID.Visible = true;
                btn_order_search.Visible = true;
                btn_order_findID.Visible = true;

                lbl_datePicker.Visible = false;
                dateTimePicker_from.Visible = false;
                dateTimePicker_to.Visible = false;
                btn_order_date_search.Visible = false;
            }
        }

        private void GetCustomerDetails()
        {
            string attribute = "customer_ID";
            GetID(attribute);

            string firstName, lastName, email;

            firstName = MakeQuery("firstName", "CUSTOMER", "customer_ID", customerID);
            lastName = MakeQuery("lastName", "CUSTOMER", "customer_ID", customerID);
            email = MakeQuery("emailAddress", "CUSTOMER", "customer_ID", customerID);

            MessageBox.Show("Customer Details : \n\n" 
                + "First Name : " + firstName + "\n"
                + "Last Name : " + lastName + "\n"
                + "Email Address : " + email);
        }

        private void GetStaffDetails()
        {
            string attribute = "staff_ID";
            GetStaffID(attribute);

            string firstName, lastName, username;

            firstName = MakeQuery("firstName", "STAFF", "staff_ID", staffID);
            lastName = MakeQuery("lastName", "STAFF", "staff_ID", staffID);
            username = MakeQuery("username", "STAFF", "staff_ID", staffID);

            MessageBox.Show("Staff Details : \n\n"
                + "First Name : " + firstName + "\n"
                + "Last Name : " + lastName + "\n"
                + "Username : " + username);
        }

        private string MakeQuery(string q, string table, string att, int ID)
        {
            string returnString = ""; 
            try
            {
                string query = "SELECT " + q + " FROM adminClass." + table + " WHERE " + att + " = " + ID + ";";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 60;
                cmd.CommandText = query;

                conn.Open();
                returnString = (string)cmd.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("Error has occured when making a query. MAKEQUERY");
            }
            finally
            {
                conn.Close();
            }
            return returnString;
        }

        private void GetID(string q)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT " + q + " FROM adminClass.ORDERS WHERE order_ID = " + search + ";", conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (!reader.IsDBNull(0))
                    {
                        if(q == "customer_ID")
                        {
                            customerID = reader.GetInt32(0);
                        }
                        else
                        {
                            MessageBox.Show("No linked records found.");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error has occured when making a query. GETID");
            }
            finally
            {
                conn.Close();
            }
        }

        private void GetStaffID(string q)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT " + q + " FROM adminClass.ORDERS WHERE order_ID = " + search + ";", conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (!reader.IsDBNull(0))
                    {
                        if (q == "staff_ID")
                        {
                            staffID = reader.GetInt32(0);
                        }
                        else
                        {
                            MessageBox.Show("No linked records found.");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("With Staff details selected.");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
