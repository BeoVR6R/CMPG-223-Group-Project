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
    public partial class AdminPanel_Reports : Form
    {
        public AdminPanel_Reports()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(form_LoginPage.path);

        int search;
        int staffID;
        int customerID;
        Int32 countOrders;

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBx_order_Date.Checked == true && chkBx_order_ID.Checked == true)
            {
                MessageBox.Show("Order ID and Order by date, may not both be selected.");
            }
            if (chkBx_order_ID.Checked ==  true)
            {
                chkBx_order_Date.Checked = false;
                chkBx_order_count.Checked = false;

                txtBx_SearchID.Visible = true;
                btn_order_search.Visible = true;
                btn_order_findID.Visible = true;

                lbl_datePicker.Visible = false;
                dateTimePicker_from.Visible = false;
                dateTimePicker_to.Visible = false;
                btn_order_date_search.Visible = false;
            }
            if (chkBx_order_ID.Checked == false)
            {
                txtBx_SearchID.Visible = false;
                btn_order_search.Visible = false;
                btn_order_findID.Visible = false;
            }
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

        private void order_include_c_details_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBx_order_Date_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBx_order_Date.Checked == true && chkBx_order_ID.Checked == true)
            {
                MessageBox.Show("Order ID and Order by date, may not both be selected.");
            }
            if (chkBx_order_Date.Checked == true)
            {
                chkBx_order_ID.Checked = false;

                txtBx_SearchID.Visible = false;
                btn_order_search.Visible = false;
                btn_order_findID.Visible = false;

                lbl_datePicker.Visible = true;
                dateTimePicker_from.Visible = true;
                dateTimePicker_to.Visible = true;
                btn_order_date_search.Visible = true;
            }
            if (chkBx_order_Date.Checked == false)
            {
                lbl_datePicker.Visible = false;
                dateTimePicker_from.Visible = false;
                dateTimePicker_to.Visible = false;
                btn_order_date_search.Visible = false;
            }
        }

        private void chkBx_order_count_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBx_order_ID.Checked == true)
            {
                MessageBox.Show("Please uncheck Order ID.");
                chkBx_order_count.Checked = false;
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
                    string countQuery = "SELECT COUNT(order_ID) FROM adminClass.ORDERS WHERE " +
                    "order_Date BETWEEN '" + dateFrom + "' AND '" + dateTo + "';";

                    countOrders = CountOrders(countQuery);

                    if(countOrders > 0)
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

        private Int32 CountOrders(string sqlQuery)
        {
            Int32 returnInteger = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 60;
                cmd.CommandText = sqlQuery;

                conn.Open();
                returnInteger = Convert.ToInt32(cmd.ExecuteScalar());
                return returnInteger;
            }
            catch
            {
                MessageBox.Show("Failed to count orders");
            }
            finally
            {
                conn.Close();
            }
            return returnInteger;
        }
    }
}
