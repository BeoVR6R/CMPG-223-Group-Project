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
    public partial class AdminPanel_Reports : Form
    {
        public AdminPanel_Reports()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(form_LoginPage.path);

        private void AdminPanel_Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grindGoDataSet3.ORDERS' table. You can move, or remove it, as needed.
            this.oRDERSTableAdapter.Fill(this.grindGoDataSet3.ORDERS);

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
            //txBx_searchCustomer.Text = "";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
