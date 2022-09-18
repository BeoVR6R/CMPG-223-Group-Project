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
    public partial class form_Homepage : Form
    {
        public form_Homepage()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=BEO-PC\SQLEXPRESS;Initial Catalog=GrindGo;Integrated Security=True");
        int counterHouseBlend = 0;
        string order = "";

        private void form_Homepage_Load(object sender, EventArgs e)
        {
            btn_Coke.Hide();
            btn_Fanta.Hide();
            btn_HouseBlend.Hide();
            btn_Cappuccino.Hide();
            lbl_Price.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_LoginPage formLogin = new form_LoginPage();
            this.Hide();
            formLogin.Show();
        }

        private void btn_adminPanel_Click(object sender, EventArgs e)
        {
            AdminLogin formAdminLogin = new AdminLogin();
            formAdminLogin.Show();
        }

        private void btn_ColdDrink_Click(object sender, EventArgs e)
        {
            btn_HouseBlend.Hide();
            btn_Cappuccino.Hide();
            btn_Coke.Show();
            btn_Fanta.Show();
        }

        private void btn_HotDrinks_Click(object sender, EventArgs e)
        {
            btn_Coke.Hide();
            btn_Fanta.Hide();
            btn_HouseBlend.Show();
            btn_Cappuccino.Show();
        }

        private void btn_HouseBlend_Click(object sender, EventArgs e)
        {
            rTB_Order.AppendText("HouseBlend\n");
        }

        private void btn_ClearOrder_Click(object sender, EventArgs e)
        {
            rTB_Order.Clear();
            counterHouseBlend = 0;
        }

        private int CalculatePrice()
        {
            int price = 0;  
            double houseBlend_Price = 9.99;
            counterHouseBlend = 0;

            for (int i = 0; i < rTB_Order.Lines.Length; i++)
            {
                if (rTB_Order.Lines[i] == "HouseBlend")
                {
                    counterHouseBlend++;
                }
            }

            price = (int)houseBlend_Price * counterHouseBlend;

            return price;
        }

        private string CalculateItems()
        {
            int counter = 0;
            for (int i = 0; i < rTB_Order.Lines.Length; i++)
            {
                if (rTB_Order.Lines[i] == "HouseBlend")
                {
                    counter++;
                }
                
            }

            return order;
        }

        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            lbl_Price.Show();
            lbl_Price.Text = "";
            int price = CalculatePrice();
            lbl_Price.Text = "Total is R: " + price;
        }

        private void btn_placeOrder_Click(object sender, EventArgs e)
        {
            order = "";
            int price = 0;
            price = CalculatePrice(); 

            if (counterHouseBlend > 0)
            {
                order += "House Blend X " + counterHouseBlend + "\n";
            }
            if (price == 0)
            {
                MessageBox.Show("Order not Placed.\n\n" +
                    "No items in order.");
            }
            else
            {
                MessageBox.Show("Order placed sucessfully.\n\n" +
                "Order NO: \n\n" +
                "Items: \n" +
                order +
                "Total R: " + price + "\n\n" +
                "Assigned to Cashier: \n");
            }
        }

        private void btn_cashierReceipt_Click(object sender, EventArgs e)
        {
            order = "";

            if (counterHouseBlend > 0)
            {
                order += "House Blend X " + counterHouseBlend + "\n";
            }

            MessageBox.Show("New Order\n\n" +
                "Order NO: \n\n" +
                "Items: \n" +
                order +
                "\nAssigned to Cashier: \n");
        }
    }
}
