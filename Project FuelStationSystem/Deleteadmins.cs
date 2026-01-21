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
    public partial class frmdeleteadmins : Form
    {
        public frmdeleteadmins()
        {
            InitializeComponent();
        }

        private void Deleteadmins_Load(object sender, EventArgs e)
        {

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
            string checkcom = "SELECT COUNT (adminname) FROM Admins WHERE adminname=@an";
            SqlCommand Check = new SqlCommand(checkcom, conn);
            Check.Parameters.AddWithValue("@an", txtadminname.Text);

            int usercount = (int)Check.ExecuteScalar();
            if (usercount == 1)
            {
                string deleteadmins = "DELETE FROM Admins WHERE adminname = @an";
                SqlCommand admindlt = new SqlCommand(deleteadmins, conn);
                admindlt.Parameters.AddWithValue("@an", txtadminname.Text);
                admindlt.ExecuteNonQuery();

                MessageBox.Show("DELETE Successful!");
            }
            else
            {
                MessageBox.Show("User does not exist!");
                txtadminname.Text = "";

            }
        }
    }
}
