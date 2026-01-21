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
    public partial class frmupdateadmins : Form
    {
        public frmupdateadmins()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmusermanagement f1 = new frmusermanagement();
            f1.Show();
            this.Hide();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == txtconfirmp.Text)
            {
                string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();
                string checkadmin = "SELECT COUNT (adminname)FROM Admins WHERE adminname =@an";
                SqlCommand admincheck = new SqlCommand(checkadmin, conn);
                admincheck.Parameters.AddWithValue("@an", txtadminname.Text);
                int usercount = (int)admincheck.ExecuteScalar();
                if (usercount == 1)
                {

                    string updateadmins = "UPDATE Admins SET Password = @pw WHERE adminname = @an";
                    SqlCommand adminupdate = new SqlCommand(updateadmins, conn);
                    adminupdate.Parameters.AddWithValue("@an", txtadminname.Text);
                    adminupdate.Parameters.AddWithValue("@pw", txtpassword.Text);
                    adminupdate.ExecuteNonQuery();

                    MessageBox.Show("Update Successful!");
                    txtadminname.Text = "";
                    txtpassword.Text = "";
                    txtconfirmp.Text = "";
                }
                else
                { MessageBox.Show("User not found!");
                    txtadminname.Text = "";
                    txtpassword.Text = "";
                    txtconfirmp.Text = "";
                }
            }
        else
                {
                    MessageBox.Show("Password are not matching!");
                    txtpassword.Text = "";
                    txtconfirmp.Text = "";

                }
            }
        }
    } 
