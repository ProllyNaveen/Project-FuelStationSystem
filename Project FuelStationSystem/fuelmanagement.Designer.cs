namespace Project_FuelStationSystem
{
    partial class frmfuelmanagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfuelmanagement));
            this.txtfuelprice = new System.Windows.Forms.TextBox();
            this.txtfuelname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datagridfuel = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridfuel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfuelprice
            // 
            this.txtfuelprice.Location = new System.Drawing.Point(232, 121);
            this.txtfuelprice.Name = "txtfuelprice";
            this.txtfuelprice.Size = new System.Drawing.Size(100, 20);
            this.txtfuelprice.TabIndex = 0;
            // 
            // txtfuelname
            // 
            this.txtfuelname.Location = new System.Drawing.Point(232, 93);
            this.txtfuelname.Name = "txtfuelname";
            this.txtfuelname.Size = new System.Drawing.Size(100, 20);
            this.txtfuelname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fuel Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price per Liter";
            // 
            // datagridfuel
            // 
            this.datagridfuel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridfuel.Location = new System.Drawing.Point(463, 27);
            this.datagridfuel.Name = "datagridfuel";
            this.datagridfuel.ReadOnly = true;
            this.datagridfuel.RowHeadersWidth = 51;
            this.datagridfuel.Size = new System.Drawing.Size(305, 150);
            this.datagridfuel.TabIndex = 4;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(202, 197);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(283, 197);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(245, 297);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 7;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(578, 208);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 8;
            this.btnrefresh.Text = "refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(693, 208);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 9;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // frmfuelmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_FuelStationSystem.Properties.Resources.black_low_poly_geometric_background_vector5;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.datagridfuel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfuelname);
            this.Controls.Add(this.txtfuelprice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmfuelmanagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fuelmanagement";
            this.Load += new System.EventHandler(this.frmfuelmanagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridfuel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfuelprice;
        private System.Windows.Forms.TextBox txtfuelname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagridfuel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnremove;
    }
}