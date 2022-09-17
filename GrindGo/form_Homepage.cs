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

        private void form_Homepage_Load(object sender, EventArgs e)
        {
            btn_Coke.Hide();
            btn_Fanta.Hide();
            btn_HouseBlend.Hide();
            btn_Cappuccino.Hide();
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
    }
}
