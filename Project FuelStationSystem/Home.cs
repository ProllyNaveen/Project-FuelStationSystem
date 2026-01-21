using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FuelStationSystem
{
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdminlogin f1 = new frmAdminlogin();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void frmhome_Load(object sender, EventArgs e)
        {
            pictureBox1.Parent = pictureBox2;
            btnlogin.Parent = pictureBox2;
            btncashier.Parent = pictureBox2;
        }

        private void btncashier_Click(object sender, EventArgs e)
        {
            frmCashierLogin f1 = new frmCashierLogin();
            f1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
