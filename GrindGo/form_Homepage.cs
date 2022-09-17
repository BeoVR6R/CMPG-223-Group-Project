using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrindGo
{
    public partial class form_Homepage : Form
    {
        public form_Homepage()
        {
            InitializeComponent();
        }

        private void form_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_LoginPage formLogin = new form_LoginPage();
            this.Hide();
            formLogin.Show();
        }
    }
}
