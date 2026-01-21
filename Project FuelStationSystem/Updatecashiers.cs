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
    public partial class frmupdatecashier : Form
    {
        public frmupdatecashier()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmusermanagement f1 = new frmusermanagement();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnewpassword.Text == txtconfirmpassword.Text)
            {
                string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();
                string checkCashier = "SELECT COUNT (Cashiername)FROM Cashier WHERE Cashiername =@cn";
                SqlCommand Cashiercheck = new SqlCommand(checkCashier, conn);
                Cashiercheck.Parameters.AddWithValue("@cn",txtcashiername.Text);
                int usercount = (int)Cashiercheck.ExecuteScalar();
                if (usercount == 1)
                {

                    string updateCashier = "UPDATE Cashier SET Password = @pw WHERE Cashiername = @cn";
                    SqlCommand Cashierupdate = new SqlCommand(updateCashier, conn);
                    Cashierupdate.Parameters.AddWithValue("@cn",txtcashiername.Text);
                    Cashierupdate.Parameters.AddWithValue("@pw",txtnewpassword.Text);
                    Cashierupdate.ExecuteNonQuery();

                    MessageBox.Show("Update Successful!");
                    txtcashiername.Text = "";
                    txtconfirmpassword.Text = "";
                    txtnewpassword.Text = "";
                }
                else
                {
                    MessageBox.Show("User not found!");
                    txtcashiername.Text = "";
                    txtconfirmpassword.Text = "";
                    txtnewpassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Password are not matching!");
                txtnewpassword.Text = "";
                txtconfirmpassword.Text = "";

            }
        }
    }
}
    

