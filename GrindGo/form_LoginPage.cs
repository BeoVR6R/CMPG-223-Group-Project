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
    public partial class form_LoginPage : Form
    {
        public form_LoginPage()
        {
            InitializeComponent();
        }

        private void lbl_Welcome_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBx_Email.Clear();
            txtBx_Password.Clear();
        }

        private void btn_DevLogin_Click(object sender, EventArgs e)
        {
            form_Homepage formHome = new form_Homepage();
            formHome.Show();
            this.Hide();
        }
    }
}
