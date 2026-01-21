namespace Project_FuelStationSystem
{
    partial class frmadminmenu
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadminmenu));
            this.dataGridadmin = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.dataGridcashier = new System.Windows.Forms.DataGridView();
            this.btnusermanagement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btntransactions = new System.Windows.Forms.Button();
            this.btninventorymanagement = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridadmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridadmin
            // 
            this.dataGridadmin.AllowUserToAddRows = false;
            this.dataGridadmin.AllowUserToDeleteRows = false;
            this.dataGridadmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridadmin.Location = new System.Drawing.Point(500, 33);
            this.dataGridadmin.Name = "dataGridadmin";
            this.dataGridadmin.ReadOnly = true;
            this.dataGridadmin.RowHeadersWidth = 51;
            this.dataGridadmin.Size = new System.Drawing.Size(240, 150);
            this.dataGridadmin.TabIndex = 0;
            this.dataGridadmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(376, 337);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(83, 38);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridcashier
            // 
            this.dataGridcashier.AllowUserToAddRows = false;
            this.dataGridcashier.AllowUserToDeleteRows = false;
            this.dataGridcashier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridcashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridcashier.Location = new System.Drawing.Point(500, 243);
            this.dataGridcashier.Name = "dataGridcashier";
            this.dataGridcashier.ReadOnly = true;
            this.dataGridcashier.RowHeadersWidth = 51;
            this.dataGridcashier.Size = new System.Drawing.Size(240, 150);
            this.dataGridcashier.TabIndex = 0;
            this.dataGridcashier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnusermanagement
            // 
            this.btnusermanagement.Location = new System.Drawing.Point(124, 128);
            this.btnusermanagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnusermanagement.Name = "btnusermanagement";
            this.btnusermanagement.Size = new System.Drawing.Size(158, 44);
            this.btnusermanagement.TabIndex = 2;
            this.btnusermanagement.Text = "User management";
            this.btnusermanagement.UseVisualStyleBackColor = true;
            this.btnusermanagement.Click += new System.EventHandler(this.btnusermanagement_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 335);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = " Fuel Management";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btntransactions
            // 
            this.btntransactions.Location = new System.Drawing.Point(124, 202);
            this.btntransactions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntransactions.Name = "btntransactions";
            this.btntransactions.Size = new System.Drawing.Size(158, 41);
            this.btntransactions.TabIndex = 4;
            this.btntransactions.Text = "Transaction History";
            this.btntransactions.UseVisualStyleBackColor = true;
            this.btntransactions.Click += new System.EventHandler(this.btntransactions_Click);
            // 
            // btninventorymanagement
            // 
            this.btninventorymanagement.Location = new System.Drawing.Point(124, 265);
            this.btninventorymanagement.Name = "btninventorymanagement";
            this.btninventorymanagement.Size = new System.Drawing.Size(158, 44);
            this.btninventorymanagement.TabIndex = 5;
            this.btninventorymanagement.Text = " Inventory Management";
            this.btninventorymanagement.UseVisualStyleBackColor = true;
            this.btninventorymanagement.Click += new System.EventHandler(this.btninventorymanagement_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project_FuelStationSystem.Properties.Resources.black_low_poly_geometric_background_vector1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 450);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmadminmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btninventorymanagement);
            this.Controls.Add(this.btntransactions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnusermanagement);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dataGridcashier);
            this.Controls.Add(this.dataGridadmin);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmadminmenu";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.frmadminmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridadmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcashier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridadmin;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dataGridcashier;
        private System.Windows.Forms.Button btnusermanagement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btntransactions;
        private System.Windows.Forms.Button btninventorymanagement;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}