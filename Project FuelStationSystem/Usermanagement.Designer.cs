namespace Project_FuelStationSystem
{
    partial class frmusermanagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmusermanagement));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtadminname = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtcashiername = new System.Windows.Forms.TextBox();
            this.txtcpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtapassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(41, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumOrchid;
            this.label3.Location = new System.Drawing.Point(41, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminsToolStripMenuItem,
            this.cashiersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminsToolStripMenuItem
            // 
            this.adminsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAdmToolStripMenuItem,
            this.deleteAdminToolStripMenuItem});
            this.adminsToolStripMenuItem.Name = "adminsToolStripMenuItem";
            this.adminsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.adminsToolStripMenuItem.Text = "Admins";
            // 
            // addAdmToolStripMenuItem
            // 
            this.addAdmToolStripMenuItem.Name = "addAdmToolStripMenuItem";
            this.addAdmToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.addAdmToolStripMenuItem.Text = "Update Admins";
            this.addAdmToolStripMenuItem.Click += new System.EventHandler(this.addAdmToolStripMenuItem_Click);
            // 
            // deleteAdminToolStripMenuItem
            // 
            this.deleteAdminToolStripMenuItem.Name = "deleteAdminToolStripMenuItem";
            this.deleteAdminToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.deleteAdminToolStripMenuItem.Text = "Delete Admins";
            this.deleteAdminToolStripMenuItem.Click += new System.EventHandler(this.deleteAdminToolStripMenuItem_Click);
            // 
            // cashiersToolStripMenuItem
            // 
            this.cashiersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCashierToolStripMenuItem,
            this.updateCashierToolStripMenuItem});
            this.cashiersToolStripMenuItem.Name = "cashiersToolStripMenuItem";
            this.cashiersToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.cashiersToolStripMenuItem.Text = "Cashiers";
            // 
            // deleteCashierToolStripMenuItem
            // 
            this.deleteCashierToolStripMenuItem.Name = "deleteCashierToolStripMenuItem";
            this.deleteCashierToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.deleteCashierToolStripMenuItem.Text = "Update Cashier";
            this.deleteCashierToolStripMenuItem.Click += new System.EventHandler(this.deleteCashierToolStripMenuItem_Click);
            // 
            // updateCashierToolStripMenuItem
            // 
            this.updateCashierToolStripMenuItem.Name = "updateCashierToolStripMenuItem";
            this.updateCashierToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.updateCashierToolStripMenuItem.Text = "Delete Cashier";
            this.updateCashierToolStripMenuItem.Click += new System.EventHandler(this.updateCashierToolStripMenuItem_Click);
            // 
            // txtadminname
            // 
            this.txtadminname.Location = new System.Drawing.Point(156, 149);
            this.txtadminname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtadminname.Name = "txtadminname";
            this.txtadminname.Size = new System.Drawing.Size(100, 22);
            this.txtadminname.TabIndex = 4;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(356, 345);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 28);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 263);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtcashiername
            // 
            this.txtcashiername.Location = new System.Drawing.Point(156, 137);
            this.txtcashiername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcashiername.Name = "txtcashiername";
            this.txtcashiername.Size = new System.Drawing.Size(100, 22);
            this.txtcashiername.TabIndex = 4;
            // 
            // txtcpassword
            // 
            this.txtcpassword.Location = new System.Drawing.Point(156, 180);
            this.txtcpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcpassword.Name = "txtcpassword";
            this.txtcpassword.Size = new System.Drawing.Size(100, 22);
            this.txtcpassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cashier Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtcpassword);
            this.panel2.Controls.Add(this.txtcashiername);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(511, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 420);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project_FuelStationSystem.Properties.Resources.Screenshot_2024_11_22_141317;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(137, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 88);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 265);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtapassword
            // 
            this.txtapassword.Location = new System.Drawing.Point(156, 182);
            this.txtapassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtapassword.Name = "txtapassword";
            this.txtapassword.Size = new System.Drawing.Size(100, 22);
            this.txtapassword.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtapassword);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 420);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Project_FuelStationSystem.Properties.Resources.Screenshot_2024_11_22_134738;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(60, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 97);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // frmusermanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_FuelStationSystem.Properties.Resources.black_low_poly_geometric_background_vector10;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtadminname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmusermanagement";
            this.Text = "Usermanagement";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCashierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCashierToolStripMenuItem;
        private System.Windows.Forms.TextBox txtadminname;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtcashiername;
        private System.Windows.Forms.TextBox txtcpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtapassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}