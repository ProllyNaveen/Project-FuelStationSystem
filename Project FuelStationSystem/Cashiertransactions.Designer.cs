namespace Project_FuelStationSystem
{
    partial class frmCashiertransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashiertransactions));
            this.cbFuelType = new System.Windows.Forms.ComboBox();
            this.txtliters = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.btnsavetransaction = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFuelType
            // 
            this.cbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuelType.FormattingEnabled = true;
            this.cbFuelType.Location = new System.Drawing.Point(160, 44);
            this.cbFuelType.Name = "cbFuelType";
            this.cbFuelType.Size = new System.Drawing.Size(121, 21);
            this.cbFuelType.TabIndex = 0;
            this.cbFuelType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtliters
            // 
            this.txtliters.Location = new System.Drawing.Point(160, 91);
            this.txtliters.Name = "txtliters";
            this.txtliters.Size = new System.Drawing.Size(121, 20);
            this.txtliters.TabIndex = 1;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(151, 158);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "Calculate!";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Location = new System.Drawing.Point(148, 212);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(99, 13);
            this.lbltotalprice.TabIndex = 3;
            this.lbltotalprice.Text = "Total Price: රු.0.00";
            // 
            // btnsavetransaction
            // 
            this.btnsavetransaction.Location = new System.Drawing.Point(286, 158);
            this.btnsavetransaction.Name = "btnsavetransaction";
            this.btnsavetransaction.Size = new System.Drawing.Size(100, 23);
            this.btnsavetransaction.TabIndex = 4;
            this.btnsavetransaction.Text = "SaveTransaction";
            this.btnsavetransaction.UseVisualStyleBackColor = true;
            this.btnsavetransaction.Click += new System.EventHandler(this.btnsavetransaction_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(416, 158);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(286, 212);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.Size = new System.Drawing.Size(474, 150);
            this.dgvTransactions.TabIndex = 6;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(587, 379);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 7;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(56, 379);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fuel Types";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Liters";
            // 
            // frmCashiertransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_FuelStationSystem.Properties.Resources.black_low_poly_geometric_background_vector3;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsavetransaction);
            this.Controls.Add(this.lbltotalprice);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtliters);
            this.Controls.Add(this.cbFuelType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCashiertransactions";
            this.Text = "Cashiertransactions";
            this.Load += new System.EventHandler(this.frmCashiertransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFuelType;
        private System.Windows.Forms.TextBox txtliters;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.Button btnsavetransaction;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}