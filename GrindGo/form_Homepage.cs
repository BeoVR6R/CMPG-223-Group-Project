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
using System.Diagnostics;
using System.Collections;

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
        int counterCappuccino = 0;
        int counterFanta = 0;
        int counterCoke = 0;
        string houseBlend = "HouseBlend";
        string cappuccino = "Cappuccino";
        string fanta = "Fanta";
        string coke = "Coke";
        int houseBlendPrice, cappuccinoPrice, fantaPrice, cokePrice;
        string order = "";
        int currentCustomerID;
        int totalPrice;
        int cashierID = 1;
        int currentOrderID;
        int stockID;
        bool orderPlaced = false;
        string currentTime = "";
        string currentDate = "";
        private void form_Homepage_Load(object sender, EventArgs e)
        {
            btn_Coke.Hide();
            btn_Fanta.Hide();
            btn_HouseBlend.Hide();
            btn_Cappuccino.Hide();
            lbl_activeUser.Text = "";
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
            order = "";
            counterHouseBlend = 0;
            counterCoke = 0;
            counterFanta = 0;
            counterCappuccino = 0;  
        }

        private int CalculatePrice()
        {
            int price = 0;
            counterHouseBlend = 0;
            counterCappuccino = 0;
            counterFanta = 0;
            counterCoke = 0;

            for (int i = 0; i < rTB_Order.Lines.Length - 1; i++)
            {
                if (rTB_Order.Lines[i] == houseBlend)
                {
                    counterHouseBlend++;
                }
                if (rTB_Order.Lines[i] == cappuccino)
                {
                    counterCappuccino++;
                }
                if (rTB_Order.Lines[i] == fanta)
                {
                    counterFanta++;
                }
                if (rTB_Order.Lines[i] == coke)
                {
                    counterCoke++;
                }
            }

            if(counterHouseBlend > 0)
            {
                houseBlendPrice = GetStockPrice(houseBlend);
                price += (houseBlendPrice * counterHouseBlend);
            }

            if (counterCappuccino > 0)
            {
                cappuccinoPrice = GetStockPrice(cappuccino);
                price += (cappuccinoPrice * counterCappuccino);
            }

            if (counterFanta > 0)
            {
                fantaPrice = GetStockPrice(fanta);
                price += (fantaPrice * counterFanta);
            }

            if (counterCoke > 0)
            {
                cokePrice = GetStockPrice(coke);
                price += (cokePrice * counterCoke);
            }

            return price;
        }

        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            totalPrice = 0;
            totalPrice = CalculatePrice();
            MessageBox.Show("Total for the order is R: " + totalPrice);
        }

        private void btn_placeOrder_Click(object sender, EventArgs e)
        {
            order = "";
            totalPrice = 0;
            totalPrice = CalculatePrice();

            order = CreateOrderOutput();
            
            if (rTB_Order.Text == "")
            {
                MessageBox.Show("Order not Placed.\n\n" +
                    "No items in order.");
            }
            else
            {
                currentTime = DateTime.Now.ToString("HH:mm:ss");
                currentDate = DateTime.Now.ToString("yyyy/MM/dd");

                string queryOrder = "INSERT INTO adminClass.ORDERS VALUES (" + "'" + currentTime + "', " + "'" + currentDate + "', "
                    + totalPrice + ", " + cashierID + ", " + currentCustomerID + ");";

                PlaceOrder(queryOrder);

                string getOrderID = "";
                getOrderID = "SELECT order_ID FROM adminClass.ORDERS WHERE order_Time = '" + currentTime + "' AND order_Date = '" + currentDate + "';";

                GetOrderID(getOrderID);

                for (int i = 0; i < rTB_Order.Lines.Length - 1; i++)
                {
                    string queryConsumable = "";
                    stockID = 0;
                    string tmp = (string)rTB_Order.Lines[i];
                    GetStockID(tmp);
                    int tmpPrice = GetStockPrice(tmp);
                    queryConsumable = "INSERT INTO adminClass.CONSUMABLE VALUES (" + stockID + ", " + tmpPrice + ", " + currentOrderID + ", 0, 'Almond', 0)";
                    PlaceConsumable(queryConsumable);

                }

                MessageBox.Show("Order placed sucessfully.\n\n" +
                "Order NO: " + currentOrderID +"\n\n" +
                "Items: \n\n" + order +
                "\n\nTotal R: " + totalPrice + "\n\n" +
                "Assigned to Cashier: Jeff Bezos\n");

                orderPlaced = true;
                rTB_Order.Clear();
            }
        }

        private void btn_cashierReceipt_Click(object sender, EventArgs e)
        {
            if (!orderPlaced)
            {
                MessageBox.Show("Error. An order first needs to be placed");
            }
            else if (orderPlaced)
            {
                MessageBox.Show("New Order\n\n" +
                "Order NO: " + currentOrderID + "\n\n" +
                "Items: \n\n" +
                 order +
                "\nCashier ID: " + cashierID);
            }
            else
            {
                MessageBox.Show("Error. Retrieving Cashier Receipt.");
            }
        }

        public void LoadCustomerInfo(int c_ID, string email)
        {
            try
            {
                lbl_activeUser.Text = "Logged in: " + email;
                currentCustomerID = c_ID;
            }
            catch
            {
                MessageBox.Show("Error loading customer info.");
            }
        }

        private void PlaceOrder(string queryorder)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 60;
                cmd.CommandText = queryorder;

                conn.Open();

                cmd.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("ERROR when placing the order.");
            }
            finally
            {
                conn.Close();
            }
        }

        private void GetOrderID(string queryOrder_ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 60;
                cmd.CommandText = queryOrder_ID;
                conn.Open();

                var returnVal = cmd.ExecuteScalar();

                if (returnVal == null)
                {
                    MessageBox.Show("Error retieving Order ID.");
                }
                else
                {
                    currentOrderID = Convert.ToInt32(returnVal);
                }
            }
            catch
            {
                MessageBox.Show("ERROR when placing the order1.");
            }
            finally
            {
                conn.Close();
            }
        }

        private void GetStockID(string consumableName)
        {
            try
            {
                string query = "SELECT stock_ID FROM adminClass.STOCK WHERE stock_desc = '" + consumableName + "';";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 60;
                cmd.CommandText = query;
                conn.Open();

                var returnVal = cmd.ExecuteScalar();

                if (returnVal == null)
                {
                    MessageBox.Show("Error retieving Stock ID.");
                }
                else
                {
                    stockID = Convert.ToInt32(returnVal);

                }
            }
            catch
            {
                MessageBox.Show("ERROR when placing the order2.");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_Cappuccino_Click(object sender, EventArgs e)
        {
            rTB_Order.AppendText("Cappuccino\n");
        }

        private void btn_Fanta_Click(object sender, EventArgs e)
        {
            rTB_Order.AppendText("Fanta\n");
        }

        private void btn_Coke_Click(object sender, EventArgs e)
        {
            rTB_Order.AppendText("Coke\n");
        }

        private void PlaceConsumable(string queryConsumble)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandTimeout = 60;
                cmd.CommandText = queryConsumble;

                conn.Open();

                cmd.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("ERROR when placing one of the consumables.");
            }
            finally
            {
                conn.Close();
            }
        }

        private int GetStockPrice(string stockName)
        {
            if (stockName == "HouseBlend")
            {
                return 10;
            }
            if (stockName == "Cappucino")
            {
                return 14;
            }
            if (stockName == "Fanta")
            {
                return 10;
            }
            if (stockName == "Coke")
            {
                return 10;
            }

            return 15;
        }

        private string CreateOrderOutput()
        {
            if (counterHouseBlend > 0)
            {
                order += "House Blend X " + counterHouseBlend + "\n";
            }
            if (counterCappuccino > 0)
            {
                order += "Cappuccino X " + counterCappuccino + "\n";
            }
            if (counterFanta > 0)
            {
                order += "Fanta X " + counterFanta + "\n";
            }
            if (counterCoke > 0)
            {
                order += "Coke X " + counterCoke + "\n";
            }
            return order;
        }
    }
}
