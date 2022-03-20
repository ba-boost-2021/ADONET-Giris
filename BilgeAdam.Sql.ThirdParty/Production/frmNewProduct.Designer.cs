namespace BilgeAdam.Sql.ThirdParty.Production
{
    partial class frmNewProduct
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
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.nudUnitsInStock = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsInStock)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(83, 109);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(258, 23);
            this.cmbCategories.TabIndex = 0;
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(83, 138);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(258, 23);
            this.cmbSuppliers.TabIndex = 0;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(83, 22);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(258, 23);
            this.txtProductName.TabIndex = 1;
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.DecimalPlaces = 2;
            this.nudUnitPrice.Location = new System.Drawing.Point(83, 51);
            this.nudUnitPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudUnitPrice.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(258, 23);
            this.nudUnitPrice.TabIndex = 2;
            this.nudUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudUnitPrice.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // nudUnitsInStock
            // 
            this.nudUnitsInStock.Location = new System.Drawing.Point(83, 80);
            this.nudUnitsInStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudUnitsInStock.Name = "nudUnitsInStock";
            this.nudUnitsInStock.Size = new System.Drawing.Size(258, 23);
            this.nudUnitsInStock.TabIndex = 2;
            this.nudUnitsInStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(266, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tedarikçi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Türü";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 228);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudUnitsInStock);
            this.Controls.Add(this.nudUnitPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.cmbSuppliers);
            this.Controls.Add(this.cmbCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewProduct";
            this.Text = "Yeni Ürün";
            this.Load += new System.EventHandler(this.frmNewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsInStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbCategories;
        private ComboBox cmbSuppliers;
        private TextBox txtProductName;
        private NumericUpDown nudUnitPrice;
        private NumericUpDown nudUnitsInStock;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCancel;
    }
}