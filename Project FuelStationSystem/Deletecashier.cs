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
    public partial class frmdeletecashier : Form
    {
        public frmdeletecashier()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmusermanagement f1 = new frmusermanagement();
            f1.Show();
            this.Hide();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string checkcom = "SELECT COUNT (Cashiername) FROM Cashier WHERE Cashiername=@cn";
            SqlCommand Check = new SqlCommand(checkcom, conn);
            Check.Parameters.AddWithValue("@cn", txtcashiername.Text);

            int usercount = (int)Check.ExecuteScalar();
            if (usercount == 1)
            {
                string deletecashier = "DELETE FROM Cashier WHERE Cashiername = @cn";
                SqlCommand Cashierdlt = new SqlCommand(deletecashier, conn);
                Cashierdlt.Parameters.AddWithValue("@cn",txtcashiername.Text);
                Cashierdlt.ExecuteNonQuery();

                MessageBox.Show("DELETE Successful!");
            }
            else
            {
                MessageBox.Show("User does not exist!");
                txtcashiername.Text = "";

            }
        }
    }
}
