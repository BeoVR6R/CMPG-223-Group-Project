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
    public partial class MaintainStaff : Form
    {
        public MaintainStaff()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=BEO-PC\SQLEXPRESS;Initial Catalog=GrindGo;Integrated Security=True");
        string search = "";

        private void MaintainStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grindGoDataSet2.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.grindGoDataSet2.STAFF);

        }

        private void btn_goBack_Staff_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPanel formAdminPanel = new AdminPanel();
            formAdminPanel.Show();
        }

        private void btn_refreshTable_Staff_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand c = new SqlCommand("SELECT firstName, lastName, id_Num, dateOfBirth, residentAddress, username FROM adminClass.STAFF", conn);
            SqlDataAdapter sda = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            txBx_searchStaff.Text = "";
        }

        private void btn_SearchStaff_Click(object sender, EventArgs e)
        {
            if (txBx_searchStaff.Text == "")
            {
                MessageBox.Show("Please enter a search field.");
            }
            else
            {
                try
                {
                    search = txBx_searchStaff.Text;
                    conn.Open();
                    SqlCommand c = new SqlCommand("SELECT firstName, lastName, id_Num, dateOfBirth, residentAddress, username" +
                        " FROM adminCLass.STAFF WHERE username = '" + search + "'" + ";", conn);
                    SqlDataAdapter sda = new SqlDataAdapter(c);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Error. Email Address not found");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btn_deleteStaff_Click(object sender, EventArgs e)
        {
            if (search == "")
            {
                MessageBox.Show("Please search for a field.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Staff with username : " + search + "\nWill be deleted, are you sure?", "ALERT", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string query = "DELETE FROM adminClass.STAFF WHERE username = '" + search + "';";

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandTimeout = 60;
                        cmd.CommandText = query;

                        conn.Open();
                        cmd.ExecuteScalar();

                        MessageBox.Show("User " + search + " Deleted Successfully.");
                    }
                    catch
                    {
                        MessageBox.Show("Error has occured.");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("No changes have been made.");
                }
            }
        }

        private void btn_createStaff_Click(object sender, EventArgs e)
        {

        }
    }
}
