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
    public partial class frmremovefueltype : Form
    {
        public frmremovefueltype()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmfuelmanagement f1 = new frmfuelmanagement();
            f1.Show();
            this.Hide();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            string fuelName = txtfuelname.Text;

            if (string.IsNullOrWhiteSpace(fuelName))
            {
                MessageBox.Show("Please enter the fuel type that you want to remove.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }

            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                string checkFuelQuery = "SELECT COUNT(*) FROM FuelTypes WHERE FuelName = @fuelName";
                SqlCommand checkCmd = new SqlCommand(checkFuelQuery, conn);
                checkCmd.Parameters.AddWithValue("@fuelName", fuelName);
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    MessageBox.Show("Fuel type not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string deleteQuery = "DELETE FROM FuelTypes WHERE FuelName = @fuelName";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                deleteCmd.Parameters.AddWithValue("@fuelName", fuelName);
                deleteCmd.ExecuteNonQuery();

                MessageBox.Show("Fuel type removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtfuelname.Text = "";
            }
        }

        private void frmremovefueltype_Load(object sender, EventArgs e)
        {

        }
    }
}
