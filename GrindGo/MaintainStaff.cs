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
    public partial class MaintainStaff : Form
    {
        public MaintainStaff()
        {
            InitializeComponent();
        }

        private void MaintainStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grindGoDataSet2.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.grindGoDataSet2.STAFF);

        }
    }
}
