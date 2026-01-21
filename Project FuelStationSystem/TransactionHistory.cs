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
    public partial class frmtransactionhistory : Form
    {
        public frmtransactionhistory()
        {
            InitializeComponent();
        }

        private void frmtransactionhistory_Load(object sender, EventArgs e)
        {
            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                string query = "SELECT t.TransactionID, f.FuelName, t.Liters, t.TotalPrice, t.TransactionDate " +
                               "FROM Transactions t " +
                               "JOIN FuelTypes f ON t.FuelID = f.FuelID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvTransactionHistory.DataSource = dt;

                decimal totalAmount = dt.AsEnumerable().Sum(row => row.Field<decimal>("TotalPrice"));
                lblTotalAmount.Text = $"Total Transactions: රු.{totalAmount:N2}";
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmadminmenu f1 = new frmadminmenu();
            f1.Show();
            this.Hide();
        }
    }
}
