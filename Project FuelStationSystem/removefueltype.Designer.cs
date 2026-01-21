namespace Project_FuelStationSystem
{
    partial class frmremovefueltype
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmremovefueltype));
            this.txtfuelname = new System.Windows.Forms.TextBox();
            this.lblfueltype = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfuelname
            // 
            this.txtfuelname.Location = new System.Drawing.Point(439, 190);
            this.txtfuelname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfuelname.Name = "txtfuelname";
            this.txtfuelname.Size = new System.Drawing.Size(132, 22);
            this.txtfuelname.TabIndex = 0;
            // 
            // lblfueltype
            // 
            this.lblfueltype.AutoSize = true;
            this.lblfueltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfueltype.Location = new System.Drawing.Point(25, 190);
            this.lblfueltype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfueltype.Name = "lblfueltype";
            this.lblfueltype.Size = new System.Drawing.Size(320, 16);
            this.lblfueltype.TabIndex = 1;
            this.lblfueltype.Text = "Please enter the fuel type you want to remove";
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(383, 285);
            this.btnremove.Margin = new System.Windows.Forms.Padding(4);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(100, 28);
            this.btnremove.TabIndex = 2;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(603, 285);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 28);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // frmremovefueltype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_FuelStationSystem.Properties.Resources.black_low_poly_geometric_background_vector6;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.lblfueltype);
            this.Controls.Add(this.txtfuelname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmremovefueltype";
            this.Text = "removefueltype";
            this.Load += new System.EventHandler(this.frmremovefueltype_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfuelname;
        private System.Windows.Forms.Label lblfueltype;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnback;
    }
}