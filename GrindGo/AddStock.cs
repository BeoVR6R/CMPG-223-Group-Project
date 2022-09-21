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
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GrindGo;Data Source=BEO-PC\SQLEXPRESS");

        private void AddStock_Load(object sender, EventArgs e)
        {

        }
    }
}
