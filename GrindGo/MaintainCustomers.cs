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
    public partial class MaintainCustomers : Form
    {
        public MaintainCustomers()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=BEO-PC\SQLEXPRESS;Initial Catalog=GrindGo;Integrated Security=True");

        private void MaintainCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grindGoDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.grindGoDataSet.CUSTOMER);

        }

        private void btn_goBack_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPanel formAdminPanel = new AdminPanel();
            formAdminPanel.Show();
        }

        private void btn_createCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer formaddCustomer = new AddCustomer();
            formaddCustomer.Show();
        }
    }
}
