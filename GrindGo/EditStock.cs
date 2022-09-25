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

namespace GrindGo
{
    public partial class EditStock : Form
    {
        public EditStock()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(form_LoginPage.path);
        int stockID = 0;

        private void EditStock_Load(object sender, EventArgs e)
        {
            txtBx_S_stockID.Text = "";
            txtBx_S_edit_Name.Text = "";
            txtBx_S_edit_costPrice.Text = "";
        }

        public void LoadStockInfo(int stockID, string stock_desc, decimal stock_costPrice)
        {
            try
            {
                this.stockID = stockID;

                txtBx_S_stockID.Text = stockID.ToString();
                txtBx_S_edit_Name.Text = stock_desc;
                txtBx_S_edit_costPrice.Text = stock_costPrice.ToString();
            }
            catch
            {
                MessageBox.Show("ERROR loading data.");
            }
        }

        private void btn_updateStock_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateStockInfo();
                MessageBox.Show("Customer updated successfully.");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error, no changes have been made");
            }
        }

        private void UpdateStockInfo()
        {
            if (txtBx_S_edit_Name.Text == "" && txtBx_S_edit_costPrice.Text == "")
            {
                MessageBox.Show("All fields are required.");
            }
            else
            {
                try
                {
                    string query = "UPDATE adminClass.STOCK SET stock_desc = '" + txtBx_S_edit_Name.Text + "', stock_costPrice = "
                        + txtBx_S_edit_costPrice.Text + " WHERE stock_ID = " + stockID + ";";

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
        }
    }
}
