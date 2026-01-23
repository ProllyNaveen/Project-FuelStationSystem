namespace Project_FuelStationSystem
{
    partial class frmdeletecashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdeletecashier));
            this.txtcashiername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcashiername
            // 
            this.txtcashiername.Location = new System.Drawing.Point(177, 60);
            this.txtcashiername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcashiername.Name = "txtcashiername";
            this.txtcashiername.Size = new System.Drawing.Size(76, 20);
            this.txtcashiername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cashier Name";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(177, 116);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(56, 19);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(280, 116);
            this.btnback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(56, 19);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // frmdeletecashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_FuelStationSystem.Properties.Resources.black_low_poly_geometric_background_vector4;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcashiername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmdeletecashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletecashier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcashiername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnback;
    }
}