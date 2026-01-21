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
    public partial class frmfuelmanagement : Form
    {
        public frmfuelmanagement()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtfuelname.Text) || string.IsNullOrWhiteSpace(txtfuelprice.Text))
            {
                MessageBox.Show("Please fill in both the Fuel Name and the Price Per Liter.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string addfuel = "INSERT INTO FuelTypes(FuelName,PricePerLiter) VALUES(@fn,@pl)";
            SqlCommand fueladd = new SqlCommand(addfuel, conn);
            fueladd.Parameters.AddWithValue("@fn", txtfuelname.Text);
            fueladd.Parameters.AddWithValue("@pl", txtfuelprice.Text);
            fueladd.ExecuteNonQuery();

            MessageBox.Show("Fuel type added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmadminmenu f1 = new frmadminmenu();
            f1.Show();
            this.Hide();
        }

        private void frmfuelmanagement_Load(object sender, EventArgs e)
        {
            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string fuelshow = "SELECT * FROM FuelTypes";
            SqlDataAdapter d1 = new SqlDataAdapter(fuelshow, conn);
            DataTable dt = new DataTable();
            d1.Fill(dt);
            datagridfuel.DataSource = dt;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string fuelshow = "SELECT * FROM FuelTypes";
            SqlDataAdapter d1 = new SqlDataAdapter(fuelshow, conn);
            DataTable dt = new DataTable();
            d1.Fill(dt);
            datagridfuel.DataSource = dt;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtfuelname.Text) || string.IsNullOrWhiteSpace(txtfuelprice.Text))
            {
                MessageBox.Show("Please fill in both the Fuel Name and the Price Per Liter.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string checkFuelQuery = "SELECT COUNT(*) FROM FuelTypes WHERE FuelName = @fuelName";
            SqlCommand checkFuelCmd = new SqlCommand(checkFuelQuery, conn);
            checkFuelCmd.Parameters.AddWithValue("@fuelName", txtfuelname.Text);

            int fuelExists = (int)checkFuelCmd.ExecuteScalar();

            if (fuelExists == 1)
            {
               
                
                string updatefuel = "UPDATE FuelTypes SET PricePerLiter = @price WHERE FuelName = @fuelName";
                SqlCommand fuelupdate = new SqlCommand(updatefuel, conn);
                fuelupdate.Parameters.AddWithValue("@fuelName", txtfuelname.Text);
                fuelupdate.Parameters.AddWithValue("@price", txtfuelprice.Text);
                fuelupdate.ExecuteNonQuery();

                MessageBox.Show("Fuel type updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fuel type not found in the database.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            frmremovefueltype f1 = new frmremovefueltype();
            f1.Show();
            this.Hide();
        }
    }
}
    
    

