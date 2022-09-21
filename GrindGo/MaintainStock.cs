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
    public partial class MaintainStock : Form
    {
        public MaintainStock()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=BEO-PC\SQLEXPRESS;Initial Catalog=GrindGo;Integrated Security=True");
        string search = "";

        private void btn_goBackStock_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPanel formAdminPanel = new AdminPanel();
            formAdminPanel.Show();
        }

        private void MaintainStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grindGoStock.STOCK' table. You can move, or remove it, as needed.
            this.sTOCKTableAdapter.Fill(this.grindGoStock.STOCK);

        }

        private void btn_refreshTable_Stock_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand c = new SqlCommand("SELECT stock_ID, stock_desc, stock_costPrice FROM adminClass.STOCK", conn);
            SqlDataAdapter sda = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewStock.DataSource = dt;
            conn.Close();
            txBx_searchStock.Text = "";
        }

        private void btn_SearchStock_Click(object sender, EventArgs e)
        {
            if (txBx_searchStock.Text == "")
            {
                MessageBox.Show("Please enter a search field.");
            }
            else
            {
                try
                {
                    search = txBx_searchStock.Text;
                    conn.Open();
                    SqlCommand c = new SqlCommand("SELECT * FROM adminCLass.STOCK WHERE stock_desc = '" + search + "';", conn);
                    SqlDataAdapter sda = new SqlDataAdapter(c);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewStock.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Error. Stock item not found");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private string GetStockDetails(string value)
        {
            string returnString = "";

            try
            {
                string query = "SELECT " + value + " FROM adminClass.STOCK WHERE stock_desc = '" + search + "';";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 60;
                cmd.CommandText = query;

                conn.Open();
                returnString = (string)cmd.ExecuteScalar();
            }
            catch
            {
                returnString = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return returnString;
        }

        private void btn_deleteStock_Click(object sender, EventArgs e)
        {
            if (search == "")
            {
                MessageBox.Show("Please search for a field.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Stock with name: " + search + "\n Will be deleted, are you sure?", "ALERT", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string query = "DELETE FROM adminClass.STOCK WHERE stock_desc = '" + search + "';";

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandTimeout = 60;
                        cmd.CommandText = query;

                        conn.Open();
                        cmd.ExecuteScalar();

                        MessageBox.Show("Item: " + search + " Deleted Successfully.");
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
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("No changes have been made.");
                }
            }
        }

        private void btn_createStock_Click(object sender, EventArgs e)
        {

        }

        private void btn_updateStock_Click(object sender, EventArgs e)
        {

        }
    }
}
