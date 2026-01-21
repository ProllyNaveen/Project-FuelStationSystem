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

namespace Project_FuelStationSystem
{
    public partial class frmusermanagement : Form
    {
        public frmusermanagement()
        {
            InitializeComponent();
        }

        private void addAdmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmupdateadmins f1 = new frmupdateadmins();
            f1.Show();
            this.Hide();
        }

        private void deleteAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdeleteadmins f1 = new frmdeleteadmins();
            f1.Show();
            this.Hide();
        }

        private void deleteCashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmupdatecashier f1 = new frmupdatecashier();
            f1.Show();
            this.Hide();
        }

        private void updateCashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdeletecashier f1 = new frmdeletecashier();
            f1.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmadminmenu f1 = new frmadminmenu();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtadminname.Text) || string.IsNullOrWhiteSpace(txtapassword.Text))
            {
                MessageBox.Show("Please fill in both the Admin Name and the Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string addadmins = "INSERT INTO Admins(adminname,Password) VALUES(@an,@pw)";
            SqlCommand adminadd = new SqlCommand(addadmins, conn);
            adminadd.Parameters.AddWithValue("@an", txtadminname.Text);
            adminadd.Parameters.AddWithValue("@pw", txtapassword.Text);
            adminadd.ExecuteNonQuery();

            MessageBox.Show("New Admin Added Success!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcashiername.Text) || string.IsNullOrWhiteSpace(txtcpassword.Text))
            {
                MessageBox.Show("Please fill in both the Cashier Name and the Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();
                string addcashiers = "INSERT INTO Cashier(Cashiername,Password) VALUES(@cn,@pw)";
                SqlCommand Cashieradd = new SqlCommand(addcashiers, conn);
                Cashieradd.Parameters.AddWithValue("@cn", txtcashiername.Text);
                Cashieradd.Parameters.AddWithValue("@pw", txtcpassword.Text);
                Cashieradd.ExecuteNonQuery();

                MessageBox.Show("New Cashier Added Success!");
            }
    } }

