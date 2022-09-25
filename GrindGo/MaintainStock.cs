using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        SqlConnection conn = new SqlConnection(form_LoginPage.path);
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

        private int GetStockID(string value)
        {
            int returnInteger = 0;

            try
            {
                string query = "SELECT " + value + " FROM adminClass.STOCK WHERE stock_desc = '" + search + "';";


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 60;
                cmd.CommandText = query;

                conn.Open();
                returnInteger = (int)cmd.ExecuteScalar(); 
            }
            catch
            {
                MessageBox.Show("Error when executing StockID query");
            }
            finally
            {
                conn.Close();
            }
            return returnInteger;
        }

        private void btn_deleteStock_Click(object sender, EventArgs e)
        {
            if (search == "")
            {
                MessageBox.Show("Please search for a field.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Stock with name: " + search + "\nWill be deleted, are you sure?", "ALERT", MessageBoxButtons.YesNo);
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
            AddStock form_addStock = new AddStock();
            form_addStock.Show();
        }

        private void btn_updateStock_Click(object sender, EventArgs e)
        {
            if (txBx_searchStock.Text == "")
            {
                MessageBox.Show("Pease enter a value in the search box.");
            }
            else
            {
                EditStock form_editStock = new EditStock();
                form_editStock.Show();

                int stockID = GetStockID("stock_ID");
                string stockName = search;
                decimal stockCostPrice = GetStockCostPrice("stock_costPrice");

                form_editStock.LoadStockInfo(stockID, stockName, stockCostPrice);
            }
        }

        private decimal GetStockCostPrice(string value)
        {
            decimal returnInteger = 0;

            try
            {
                string query = "SELECT " + value + " FROM adminClass.STOCK WHERE stock_desc = '" + search + "';";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 60;
                cmd.CommandText = query;

                conn.Open();
                returnInteger = (decimal)cmd.ExecuteScalar();

            }
            catch
            {
                MessageBox.Show("Error when executing StockCostPrice query");
            }
            finally
            {
                conn.Close();
            }
            return returnInteger;
        }
    }
}
