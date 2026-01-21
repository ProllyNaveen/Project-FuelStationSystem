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
    public partial class frmInventoryManagement : Form
    {
        public frmInventoryManagement()
        {
            InitializeComponent();
        }

        private void frmInventoryManagement_Load(object sender, EventArgs e)
        {
            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();

                string query = "SELECT f.FuelName, i.StockLevel FROM FuelInventory i " +
                               "JOIN FuelTypes f ON i.FuelID = f.FuelID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvFuelInventory.DataSource = dt;

                string query2 = "SELECT FuelName FROM FuelTypes";
                SqlCommand cmd = new SqlCommand(query2, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbfuelname.Items.Add(reader["FuelName"].ToString());
                }

                reader.Close();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmadminmenu f1 = new frmadminmenu();
            f1.Show();
            this.Hide();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            string fuelName = cbfuelname.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(fuelName))
            {
                MessageBox.Show("Please select a valid fuel type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal newStock;
            if (!decimal.TryParse(txtNewStock.Text, out newStock) || newStock <= 0)
            {
                MessageBox.Show("Please enter a valid number for the stock level.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();

                string checkFuelExistQuery = "SELECT COUNT(*) FROM FuelTypes WHERE FuelName = @fuelName";
                SqlCommand checkCmd = new SqlCommand(checkFuelExistQuery, conn);
                checkCmd.Parameters.AddWithValue("@fuelName", fuelName);
                int fuelCount = (int)checkCmd.ExecuteScalar();

                if (fuelCount == 0)
                {
                    MessageBox.Show("Fuel type not found. Please select a valid fuel type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string checkInventoryExistQuery = "SELECT COUNT(*) FROM FuelInventory WHERE FuelID = (SELECT FuelID FROM FuelTypes WHERE FuelName = @fuelName)";
                SqlCommand checkInventoryCmd = new SqlCommand(checkInventoryExistQuery, conn);
                checkInventoryCmd.Parameters.AddWithValue("@fuelName", fuelName);
                int inventoryCount = (int)checkInventoryCmd.ExecuteScalar();

                if (inventoryCount == 0)
                {
                    string insertInventoryQuery = "INSERT INTO FuelInventory (FuelID, StockLevel) " +
                                                  "VALUES ((SELECT FuelID FROM FuelTypes WHERE FuelName = @fuelName), @stock)";
                    SqlCommand insertCmd = new SqlCommand(insertInventoryQuery, conn);
                    insertCmd.Parameters.AddWithValue("@fuelName", fuelName);
                    insertCmd.Parameters.AddWithValue("@stock", newStock);
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Fuel inventory added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string getCurrentStockQuery = "SELECT StockLevel FROM FuelInventory WHERE FuelID = (SELECT FuelID FROM FuelTypes WHERE FuelName = @fuelName)";
                    SqlCommand getStockCmd = new SqlCommand(getCurrentStockQuery, conn);
                    getStockCmd.Parameters.AddWithValue("@fuelName", fuelName);
                    decimal currentStock = (decimal)getStockCmd.ExecuteScalar();

                    decimal updatedStock = currentStock + newStock;

                    string updateStockQuery = "UPDATE FuelInventory SET StockLevel = @stock WHERE FuelID = (SELECT FuelID FROM FuelTypes WHERE FuelName = @fuelName)";
                    SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, conn);
                    updateStockCmd.Parameters.AddWithValue("@fuelName", fuelName);
                    updateStockCmd.Parameters.AddWithValue("@stock", updatedStock);
                    updateStockCmd.ExecuteNonQuery();

                    MessageBox.Show("Fuel inventory updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                string query = "SELECT f.FuelName, i.StockLevel FROM FuelInventory i " +
                               "JOIN FuelTypes f ON i.FuelID = f.FuelID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvFuelInventory.DataSource = dt;
            }
        }
    }
}
