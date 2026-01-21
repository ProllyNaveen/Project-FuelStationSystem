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
    public partial class frmAdminlogin : Form
    {
        public frmAdminlogin()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmhome f2 = new frmhome();
            f2.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtadminname.Text) || string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Please fill in both the Admin Name and the Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string checkcom = "SELECT COUNT (adminname) FROM Admins WHERE adminname=@an";
            SqlCommand Check = new SqlCommand(checkcom,conn);
            Check.Parameters.AddWithValue("@an",txtadminname.Text);
            
            int usercount= (int)Check.ExecuteScalar();
            if (usercount == 1)
            {
                string checkcom2 = "SELECT COUNT(adminname) FROM Admins WHERE adminname=@an AND Password=@pw";
                SqlCommand Check2 = new SqlCommand(checkcom2, conn);
                Check2.Parameters.AddWithValue("@an",txtadminname.Text);
                Check2.Parameters.AddWithValue("@pw",txtpassword.Text);
                int passwordcount = (int)Check2.ExecuteScalar();
                if (passwordcount == 1)
                {
                    frmadminmenu f1 = new frmadminmenu();
                    f1.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Password is incorrect!");
                    txtpassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("User does not exist!");
                txtadminname.Text = "";
                txtpassword.Text = "";

            }
        }
    }
}
