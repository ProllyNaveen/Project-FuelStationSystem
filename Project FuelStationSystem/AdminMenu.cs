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
    public partial class frmadminmenu : Form
    {
        public frmadminmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmhome f2 = new frmhome();
            f2.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmadminmenu_Load(object sender, EventArgs e)
        {
            string connstring = "Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string datashow = "SELECT * FROM Admins";
            SqlDataAdapter d1 = new SqlDataAdapter(datashow,connstring);
            DataTable dt = new DataTable();
            d1.Fill(dt);
            dataGridadmin.DataSource = dt;
            dataGridadmin.Columns["admin_id"].DisplayIndex = 0;
            string datashow2 = "SELECT * FROM Cashier";
            SqlDataAdapter d2 = new SqlDataAdapter(datashow2, connstring);
            DataTable dt2 = new DataTable();
            d2.Fill(dt2);
            dataGridcashier.DataSource = dt2;
            dataGridcashier.Columns["Cashierid"].DisplayIndex = 0;

        }

        private void btnusermanagement_Click(object sender, EventArgs e)
        {
            frmusermanagement f1 = new frmusermanagement();
            f1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmfuelmanagement f1 = new frmfuelmanagement();
            f1.Show();
            this.Hide();
        }

        private void btntransactions_Click(object sender, EventArgs e)
        {
            frmtransactionhistory f1 = new frmtransactionhistory();
            f1.Show();
            this.Hide();
        }

        private void btninventorymanagement_Click(object sender, EventArgs e)
        {
            frmInventoryManagement f1 = new frmInventoryManagement();
            f1.Show();
            this.Hide();
        }
    }
}
