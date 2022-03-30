namespace Tratel.EndUser
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.uygulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msbUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.msbNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.placeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msbPlaceList = new System.Windows.Forms.ToolStripMenuItem();
            this.metaVeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msbLookUpTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAddLookUpType = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uygulamaToolStripMenuItem,
            this.placeToolStripMenuItem,
            this.kullanıcıToolStripMenuItem,
            this.metaVeriToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1107, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // uygulamaToolStripMenuItem
            // 
            this.uygulamaToolStripMenuItem.Name = "uygulamaToolStripMenuItem";
            this.uygulamaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.uygulamaToolStripMenuItem.Text = "Uygulama";
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbUserManagement,
            this.msbNewUser});
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            // 
            // msbUserManagement
            // 
            this.msbUserManagement.Name = "msbUserManagement";
            this.msbUserManagement.Size = new System.Drawing.Size(164, 22);
            this.msbUserManagement.Text = "Kullanıcı Yönetici";
            this.msbUserManagement.Click += new System.EventHandler(this.msbUserManagement_Click);
            // 
            // msbNewUser
            // 
            this.msbNewUser.Name = "msbNewUser";
            this.msbNewUser.Size = new System.Drawing.Size(164, 22);
            this.msbNewUser.Text = "Yeni Kullanıcı";
            this.msbNewUser.Click += new System.EventHandler(this.msbNewUser_Click);
            // 
            // metaVeriToolStripMenuItem
            // 
            this.metaVeriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbLookUpTypes});
            this.metaVeriToolStripMenuItem.Name = "metaVeriToolStripMenuItem";
            this.metaVeriToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.metaVeriToolStripMenuItem.Text = "MetaVeri";
            // 
            // msbLookUpTypes
            // 
            this.msbLookUpTypes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAddLookUpType});
            this.msbLookUpTypes.Name = "msbLookUpTypes";
            this.msbLookUpTypes.Size = new System.Drawing.Size(180, 22);
            this.msbLookUpTypes.Text = "MetaVeri Tipleri";
            this.msbLookUpTypes.Click += new System.EventHandler(this.msbLookUpTypes_Click);
            // 
            // cmsAddLookUpType
            // 
            this.cmsAddLookUpType.Name = "cmsAddLookUpType";
            this.cmsAddLookUpType.Size = new System.Drawing.Size(180, 22);
            this.cmsAddLookUpType.Text = "Tip Ekle";
            this.cmsAddLookUpType.Click += new System.EventHandler(this.cmsAddLookUpType_Click);
            // 
            // placeToolStripMenuItem
            // 
            this.placeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbPlaceList});
            this.placeToolStripMenuItem.Name = "placeToolStripMenuItem";
            this.placeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.placeToolStripMenuItem.Text = "Place";
            // 
            // msbPlaceList
            // 
            this.msbPlaceList.Name = "msbPlaceList";
            this.msbPlaceList.Size = new System.Drawing.Size(180, 22);
            this.msbPlaceList.Text = "Places";
            this.msbPlaceList.Click += new System.EventHandler(this.msbPlaceList_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 609);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "frmMain";
            this.Text = "Tratel - Agency v1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem uygulamaToolStripMenuItem;
        private ToolStripMenuItem kullanıcıToolStripMenuItem;
        private ToolStripMenuItem msbUserManagement;
        private ToolStripMenuItem msbNewUser;
        private ToolStripMenuItem metaVeriToolStripMenuItem;
        private ToolStripMenuItem msbLookUpTypes;
        private ToolStripMenuItem cmsAddLookUpType;
        private ToolStripMenuItem placeToolStripMenuItem;
        private ToolStripMenuItem msbPlaceList;
    }
}