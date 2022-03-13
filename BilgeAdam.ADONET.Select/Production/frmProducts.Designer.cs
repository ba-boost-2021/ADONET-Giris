namespace BilgeAdam.ADONET.Select.Production
{
    partial class frmProducts
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.cmbItemCount = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(103, 22);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(191, 23);
            this.cmbCategories.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearFilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSuppliers);
            this.groupBox1.Controls.Add(this.cmbCategories);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtre";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(652, 22);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(123, 23);
            this.btnClearFilter.TabIndex = 2;
            this.btnClearFilter.Text = "Filtreyi Temizle";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Sağlayıcısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Kategorisi";
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(402, 22);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(244, 23);
            this.cmbSuppliers.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcId,
            this.dgcName,
            this.dgcStock,
            this.dgcPrice,
            this.dgcCategory,
            this.dgcSupplier});
            this.dgvProducts.Location = new System.Drawing.Point(12, 82);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(781, 428);
            this.dgvProducts.TabIndex = 2;
            // 
            // dgcId
            // 
            this.dgcId.DataPropertyName = "Id";
            this.dgcId.HeaderText = "ID";
            this.dgcId.Name = "dgcId";
            this.dgcId.ReadOnly = true;
            // 
            // dgcName
            // 
            this.dgcName.DataPropertyName = "Name";
            this.dgcName.HeaderText = "Ürün Adı";
            this.dgcName.Name = "dgcName";
            this.dgcName.ReadOnly = true;
            // 
            // dgcStock
            // 
            this.dgcStock.DataPropertyName = "Stock";
            this.dgcStock.HeaderText = "Stok";
            this.dgcStock.Name = "dgcStock";
            this.dgcStock.ReadOnly = true;
            // 
            // dgcPrice
            // 
            this.dgcPrice.DataPropertyName = "Price";
            this.dgcPrice.HeaderText = "Fiyat";
            this.dgcPrice.Name = "dgcPrice";
            this.dgcPrice.ReadOnly = true;
            // 
            // dgcCategory
            // 
            this.dgcCategory.DataPropertyName = "Category";
            this.dgcCategory.HeaderText = "Türü";
            this.dgcCategory.Name = "dgcCategory";
            this.dgcCategory.ReadOnly = true;
            // 
            // dgcSupplier
            // 
            this.dgcSupplier.DataPropertyName = "Company";
            this.dgcSupplier.HeaderText = "Tedarikçi";
            this.dgcSupplier.Name = "dgcSupplier";
            this.dgcSupplier.ReadOnly = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(718, 516);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.Location = new System.Drawing.Point(637, 516);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // cmbItemCount
            // 
            this.cmbItemCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemCount.FormattingEnabled = true;
            this.cmbItemCount.Items.AddRange(new object[] {
            "15",
            "20",
            "25"});
            this.cmbItemCount.Location = new System.Drawing.Point(575, 516);
            this.cmbItemCount.Name = "cmbItemCount";
            this.cmbItemCount.Size = new System.Drawing.Size(56, 23);
            this.cmbItemCount.TabIndex = 4;
            this.cmbItemCount.SelectedIndexChanged += new System.EventHandler(this.cmbItemCount_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ürün Adedi";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(85, 516);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(81, 23);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kayıt Sayısı";
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 551);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbItemCount);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProducts";
            this.Text = "Ürün İşlemleri";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbCategories;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox cmbSuppliers;
        private DataGridView dgvProducts;
        private Button btnClearFilter;
        private Button btnNext;
        private Button btnPrevious;
        private ComboBox cmbItemCount;
        private Label label3;
        private DataGridViewTextBoxColumn dgcId;
        private DataGridViewTextBoxColumn dgcName;
        private DataGridViewTextBoxColumn dgcStock;
        private DataGridViewTextBoxColumn dgcPrice;
        private DataGridViewTextBoxColumn dgcCategory;
        private DataGridViewTextBoxColumn dgcSupplier;
        private TextBox txtTotal;
        private Label label4;
    }
}