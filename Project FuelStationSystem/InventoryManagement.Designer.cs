namespace Project_FuelStationSystem
{
    partial class frmInventoryManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryManagement));
            this.dgvFuelInventory = new System.Windows.Forms.DataGridView();
            this.txtNewStock = new System.Windows.Forms.TextBox();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.cbfuelname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuelInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuelInventory
            // 
            this.dgvFuelInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuelInventory.Location = new System.Drawing.Point(544, 78);
            this.dgvFuelInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFuelInventory.Name = "dgvFuelInventory";
            this.dgvFuelInventory.RowHeadersWidth = 51;
            this.dgvFuelInventory.Size = new System.Drawing.Size(320, 185);
            this.dgvFuelInventory.TabIndex = 0;
            // 
            // txtNewStock
            // 
            this.txtNewStock.Location = new System.Drawing.Point(165, 309);
            this.txtNewStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewStock.Name = "txtNewStock";
            this.txtNewStock.Size = new System.Drawing.Size(132, 22);
            this.txtNewStock.TabIndex = 2;
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(179, 395);
            this.btnUpdateStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(120, 28);
            this.btnUpdateStock.TabIndex = 3;
            this.btnUpdateStock.Text = "UpdateStock";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Stock";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(433, 395);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 28);
            this.btnback.TabIndex = 6;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(653, 301);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(100, 28);
            this.btnrefresh.TabIndex = 7;
            this.btnrefresh.Text = "refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // cbfuelname
            // 
            this.cbfuelname.FormattingEnabled = true;
            this.cbfuelname.Location = new System.Drawing.Point(165, 238);
            this.cbfuelname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbfuelname.Name = "cbfuelname";
            this.cbfuelname.Size = new System.Drawing.Size(160, 24);
            this.cbfuelname.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fuel Type";
            // 
            // frmInventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_FuelStationSystem.Properties.Resources.black_low_poly_geometric_background_vector;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbfuelname);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.txtNewStock);
            this.Controls.Add(this.dgvFuelInventory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInventoryManagement";
            this.Text = "InventoryManagement";
            this.Load += new System.EventHandler(this.frmInventoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuelInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuelInventory;
        private System.Windows.Forms.TextBox txtNewStock;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.ComboBox cbfuelname;
        private System.Windows.Forms.Label label1;
    }
}