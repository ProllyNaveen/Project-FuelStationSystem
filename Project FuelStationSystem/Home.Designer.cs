namespace Project_FuelStationSystem
{
    partial class frmhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhome));
            this.label1 = new System.Windows.Forms.Label();
            this.btncashier = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome to Lanka Fueling Station System!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncashier
            // 
            this.btncashier.BackColor = System.Drawing.Color.Transparent;
            this.btncashier.BackgroundImage = global::Project_FuelStationSystem.Properties.Resources.Captucashierre_removebg_preview;
            this.btncashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncashier.FlatAppearance.BorderSize = 0;
            this.btncashier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncashier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btncashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncashier.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btncashier.Location = new System.Drawing.Point(650, 13);
            this.btncashier.Margin = new System.Windows.Forms.Padding(2);
            this.btncashier.Name = "btncashier";
            this.btncashier.Size = new System.Drawing.Size(148, 98);
            this.btncashier.TabIndex = 4;
            this.btncashier.UseVisualStyleBackColor = false;
            this.btncashier.Click += new System.EventHandler(this.btncashier_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.BackgroundImage = global::Project_FuelStationSystem.Properties.Resources.Capadaminture_removebg_preview;
            this.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnlogin.Location = new System.Drawing.Point(518, 13);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(139, 98);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project_FuelStationSystem.Properties.Resources.ceypetco_logo3;
            this.pictureBox1.Location = new System.Drawing.Point(248, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Project_FuelStationSystem.Properties.Resources.istockphoto_1329937925_612x612;
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(798, 465);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.btncashier);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmhome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btncashier;
        private System.Windows.Forms.Button btnlogin;
    }
}

