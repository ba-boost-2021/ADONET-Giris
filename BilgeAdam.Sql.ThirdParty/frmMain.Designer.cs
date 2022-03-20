namespace BilgeAdam.Sql.ThirdParty
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uygulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msbSalesHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msbStocks = new System.Windows.Forms.ToolStripMenuItem();
            this.insanKaynaklarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msbEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.msbNewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uygulamaToolStripMenuItem,
            this.satışToolStripMenuItem,
            this.ürünToolStripMenuItem,
            this.insanKaynaklarıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(951, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uygulamaToolStripMenuItem
            // 
            this.uygulamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.uygulamaToolStripMenuItem.Name = "uygulamaToolStripMenuItem";
            this.uygulamaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.uygulamaToolStripMenuItem.Text = "Uygulama";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.faturaToolStripMenuItem,
            this.msbSalesHistory});
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.satışToolStripMenuItem.Text = "Satış";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.faturaToolStripMenuItem.Text = "Fatura";
            // 
            // msbSalesHistory
            // 
            this.msbSalesHistory.Name = "msbSalesHistory";
            this.msbSalesHistory.Size = new System.Drawing.Size(143, 22);
            this.msbSalesHistory.Text = "Satış Geçmişi";
            this.msbSalesHistory.Click += new System.EventHandler(this.msbSalesHistory_Click);
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbStocks,
            this.msbNewProduct});
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.ürünToolStripMenuItem.Text = "Ürün";
            // 
            // msbStocks
            // 
            this.msbStocks.Name = "msbStocks";
            this.msbStocks.Size = new System.Drawing.Size(180, 22);
            this.msbStocks.Text = "Stok Yönetimi";
            this.msbStocks.Click += new System.EventHandler(this.msbStocks_Click);
            // 
            // insanKaynaklarıToolStripMenuItem
            // 
            this.insanKaynaklarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbEmployees});
            this.insanKaynaklarıToolStripMenuItem.Name = "insanKaynaklarıToolStripMenuItem";
            this.insanKaynaklarıToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.insanKaynaklarıToolStripMenuItem.Text = "İnsan Kaynakları";
            // 
            // msbEmployees
            // 
            this.msbEmployees.Name = "msbEmployees";
            this.msbEmployees.Size = new System.Drawing.Size(154, 22);
            this.msbEmployees.Text = "Personel Listesi";
            this.msbEmployees.Click += new System.EventHandler(this.msbEmployees_Click);
            // 
            // msbNewProduct
            // 
            this.msbNewProduct.Name = "msbNewProduct";
            this.msbNewProduct.Size = new System.Drawing.Size(180, 22);
            this.msbNewProduct.Text = "Yeni Ürün";
            this.msbNewProduct.Click += new System.EventHandler(this.msbNewProduct_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 598);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Northwind";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem uygulamaToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem satışToolStripMenuItem;
        private ToolStripMenuItem yeniToolStripMenuItem;
        private ToolStripMenuItem faturaToolStripMenuItem;
        private ToolStripMenuItem msbSalesHistory;
        private ToolStripMenuItem ürünToolStripMenuItem;
        private ToolStripMenuItem msbStocks;
        private ToolStripMenuItem insanKaynaklarıToolStripMenuItem;
        private ToolStripMenuItem msbEmployees;
        private ToolStripMenuItem msbNewProduct;
    }
}