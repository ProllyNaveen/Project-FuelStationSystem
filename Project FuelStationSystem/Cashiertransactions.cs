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
    public partial class frmCashiertransactions : Form
    {
        public frmCashiertransactions()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCashiertransactions_Load(object sender, EventArgs e)
        {
            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                string query = "SELECT FuelName FROM FuelTypes";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbFuelType.Items.Add(reader["FuelName"].ToString());
                }

                reader.Close();

                string query1 = @"
                    SELECT TOP 3 t.TransactionID, f.FuelName, t.Liters, t.TotalPrice, t.TransactionDate 
                    FROM Transactions t 
                    JOIN FuelTypes f ON t.FuelID = f.FuelID
                    ORDER BY t.TransactionDate DESC";

                DataTable dt = new DataTable();

                using (SqlConnection conn1 = new SqlConnection(connstring))
                {
                    conn1.Open();
                    SqlCommand cmd1 = new SqlCommand(query1, conn1);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                    adapter.Fill(dt);
                }

                dgvTransactions.DataSource = dt;

            }
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            if (cbFuelType.SelectedItem == null || string.IsNullOrWhiteSpace(txtliters.Text))
            {
                MessageBox.Show("Please select a fuel type and enter the number of liters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();

                string query = "SELECT PricePerLiter FROM FuelTypes WHERE FuelName = @fuel";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fuel", cbFuelType.SelectedItem.ToString());
                decimal pricePerLiter = (decimal)cmd.ExecuteScalar();

                if (!int.TryParse(txtliters.Text, out int liters))
                {
                    MessageBox.Show("Please enter a valid number of liters!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal totalPrice = pricePerLiter * liters;
                lbltotalprice.Text = $"Total Price: රු.{totalPrice:N2}";

                string getCurrentStockQuery = "SELECT StockLevel FROM FuelInventory WHERE FuelID = (SELECT FuelID FROM FuelTypes WHERE FuelName = @fuelName)";
                SqlCommand getStockCmd = new SqlCommand(getCurrentStockQuery, conn);
                getStockCmd.Parameters.AddWithValue("@fuelName", cbFuelType.SelectedItem.ToString());
                decimal currentStock = (decimal)getStockCmd.ExecuteScalar();

                if (currentStock < liters)
                {
                    MessageBox.Show("Not enough fuel in stock to complete this transaction.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal updatedStock = currentStock - liters;

                if (updatedStock < 10)
                {
                    MessageBox.Show("Warning: Fuel level is low. Please restock soon.", "Low Fuel Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                string updateStockQuery = "UPDATE FuelInventory SET StockLevel = @stock WHERE FuelID = (SELECT FuelID FROM FuelTypes WHERE FuelName = @fuelName)";
                SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, conn);
                updateStockCmd.Parameters.AddWithValue("@fuelName", cbFuelType.SelectedItem.ToString());
                updateStockCmd.Parameters.AddWithValue("@stock", updatedStock);
                updateStockCmd.ExecuteNonQuery();

                MessageBox.Show("Fuel sale completed and inventory updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cbFuelType.SelectedIndex = -1;
            txtliters.Clear();
            lbltotalprice.Text = "Total Price: රු.0.00";
        }

        private void btnsavetransaction_Click(object sender, EventArgs e)
        {
            if (cbFuelType.SelectedItem == null || string.IsNullOrWhiteSpace(txtliters.Text))
            {
                MessageBox.Show("Please complete the transaction details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal liters;
            if (!decimal.TryParse(txtliters.Text, out liters))
            {
                MessageBox.Show("Please enter a valid number of liters!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalPrice;
            string priceText = lbltotalprice.Text.Replace("Total Price: රු.", "").Trim();  // Adjust the currency symbol handling
            if (!decimal.TryParse(priceText, out totalPrice))
            {
                MessageBox.Show("The total price format is incorrect.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();  
                string getFuelID = "SELECT FuelID FROM FuelTypes WHERE FuelName = @fuel";
                SqlCommand getFuelCmd = new SqlCommand(getFuelID, conn);
                getFuelCmd.Parameters.AddWithValue("@fuel", cbFuelType.SelectedItem.ToString());
                int fuelID = (int)getFuelCmd.ExecuteScalar();

                string saveTransaction = "INSERT INTO Transactions (FuelID, Liters, TotalPrice) VALUES (@fuelID, @liters, @total)";
                SqlCommand saveCmd = new SqlCommand(saveTransaction, conn);
                saveCmd.Parameters.AddWithValue("@fuelID", fuelID);
                saveCmd.Parameters.AddWithValue("@liters", liters);
                saveCmd.Parameters.AddWithValue("@total", totalPrice);

                saveCmd.ExecuteNonQuery();
                MessageBox.Show("Transaction saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                cbFuelType.SelectedIndex = -1;
                txtliters.Clear();
                lbltotalprice.Text = "Total Price: ";
            }

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            string connstring1 = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
            string query1 = @"
                SELECT TOP 3 t.TransactionID, f.FuelName, t.Liters, t.TotalPrice, t.TransactionDate 
                FROM Transactions t 
                JOIN FuelTypes f ON t.FuelID = f.FuelID
                ORDER BY t.TransactionDate DESC";

            DataTable dt = new DataTable();

            using (SqlConnection conn1 = new SqlConnection(connstring1))
            {
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand(query1, conn1);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                adapter.Fill(dt);
            }

            dgvTransactions.DataSource = dt;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmhome f1 = new frmhome();
            f1.Show();
            this.Hide();
        }
    }
}

