namespace Project_FuelStationSystem
{
    partial class frmdeleteadmins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdeleteadmins));
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadminname = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Name";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(191, 154);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(56, 19);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // txtadminname
            // 
            this.txtadminname.Location = new System.Drawing.Point(235, 95);
            this.txtadminname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtadminname.Name = "txtadminname";
            this.txtadminname.Size = new System.Drawing.Size(76, 20);
            this.txtadminname.TabIndex = 0;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(309, 154);
            this.btnback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(56, 19);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // frmdeleteadmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_FuelStationSystem.Properties.Resources.black_low_poly_geometric_background_vector8;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadminname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmdeleteadmins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deleteadmins";
            this.Load += new System.EventHandler(this.Deleteadmins_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadminname;
        private System.Windows.Forms.Button btnback;
    }
}