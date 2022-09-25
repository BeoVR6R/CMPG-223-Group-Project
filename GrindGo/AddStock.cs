using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrindGo
{
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(form_LoginPage.path);

        private void AddStock_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_s_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addStock_Click(object sender, EventArgs e)
        {
            string stockItemName = txtBx_S_itemName.Text;
            decimal stockItemCost;


            if (txtBx_S_itemName.Text == "" || txtBx_S_itemCostPrice.Text == "")
            {
                MessageBox.Show("All fields are required.");
            }
            else
            {
                if (Decimal.TryParse(txtBx_S_itemCostPrice.Text, out stockItemCost))
                {
                    stockItemCost = Convert.ToDecimal(stockItemCost);
                    DialogResult dialogResult = MessageBox.Show("Item: " + stockItemName + "\nWith cost price: " + stockItemCost + "\nWill be added." +
                    "\n\nAre you sure?", "ALERT", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        AddStockItems(stockItemName, stockItemCost);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("No changes have been made.");
                    }
                }
                else
                {
                    MessageBox.Show("Field stock cost price is not number.");
                }
            }
        }

        private void AddStockItems(string itemName, decimal itemCostPrice)
        {
            try
            {
                string query = "INSERT INTO adminClass.STOCK VALUES ('" + itemName + "', " + itemCostPrice + ");";

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
                MessageBox.Show("Error adding item into STOCK.");
            }
            finally
            {
                conn.Close();   
            }
        }
    }
}
