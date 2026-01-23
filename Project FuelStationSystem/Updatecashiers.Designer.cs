namespace Project_FuelStationSystem
{
    partial class frmupdatecashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmupdatecashier));
            this.txtcashiername = new System.Windows.Forms.TextBox();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.aa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcashiername
            // 
            this.txtcashiername.Location = new System.Drawing.Point(196, 60);
            this.txtcashiername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcashiername.Name = "txtcashiername";
            this.txtcashiername.Size = new System.Drawing.Size(76, 20);
            this.txtcashiername.TabIndex = 0;
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(196, 98);
            this.txtnewpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(76, 20);
            this.txtnewpassword.TabIndex = 1;
            // 
            // aa
            // 
            this.aa.AutoSize = true;
            this.aa.Location = new System.Drawing.Point(108, 63);
            this.aa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(73, 13);
            this.aa.TabIndex = 2;
            this.aa.Text = "Cashier Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 166);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(311, 165);
            this.btnback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(56, 19);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Location = new System.Drawing.Point(196, 122);
            this.txtconfirmpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(76, 20);
            this.txtconfirmpassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Confirm Password";
            // 
            // frmupdatecashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_FuelStationSystem.Properties.Resources.black_low_poly_geometric_background_vector9;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aa);
            this.Controls.Add(this.txtconfirmpassword);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.txtcashiername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmupdatecashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updatecashiers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcashiername;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.Label aa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.Label label1;
    }
}