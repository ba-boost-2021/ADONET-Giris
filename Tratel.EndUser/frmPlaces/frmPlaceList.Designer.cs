namespace Tratel.EndUser
{
    partial class frmPlaceList
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
            this.components = new System.ComponentModel.Container();
            this.dgvPlaces = new System.Windows.Forms.DataGridView();
            this.cmsPlace = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddPlace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaces)).BeginInit();
            this.cmsPlace.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPlaces
            // 
            this.dgvPlaces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaces.Location = new System.Drawing.Point(13, 50);
            this.dgvPlaces.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPlaces.Name = "dgvPlaces";
            this.dgvPlaces.ReadOnly = true;
            this.dgvPlaces.RowHeadersWidth = 62;
            this.dgvPlaces.RowTemplate.Height = 25;
            this.dgvPlaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlaces.Size = new System.Drawing.Size(1109, 554);
            this.dgvPlaces.TabIndex = 0;
            this.dgvPlaces.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPlaces_CellMouseUp);
            // 
            // cmsPlace
            // 
            this.cmsPlace.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsPlace.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEdit,
            this.cmsDelete});
            this.cmsPlace.Name = "contextMenuStrip1";
            this.cmsPlace.Size = new System.Drawing.Size(148, 68);
            // 
            // cmsEdit
            // 
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(147, 32);
            this.cmsEdit.Text = "Düzenle";
            this.cmsEdit.Click += new System.EventHandler(this.cmsEdit_Click);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(147, 32);
            this.cmsDelete.Text = "Sil";
            this.cmsDelete.Click += new System.EventHandler(this.cmsDelete_Click);
            // 
            // btnAddPlace
            // 
            this.btnAddPlace.Location = new System.Drawing.Point(885, 651);
            this.btnAddPlace.Name = "btnAddPlace";
            this.btnAddPlace.Size = new System.Drawing.Size(188, 56);
            this.btnAddPlace.TabIndex = 1;
            this.btnAddPlace.Text = "Yeni";
            this.btnAddPlace.UseVisualStyleBackColor = true;
            this.btnAddPlace.Click += new System.EventHandler(this.btnAddPlace_Click);
            // 
            // frmPlaceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.btnAddPlace);
            this.Controls.Add(this.dgvPlaces);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPlaceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPlaceList";
            this.Load += new System.EventHandler(this.frmPlaceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaces)).EndInit();
            this.cmsPlace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvPlaces;
        private ContextMenuStrip cmsPlace;
        private ToolStripMenuItem cmsEdit;
        private ToolStripMenuItem cmsDelete;
        private Button btnAddPlace;
    }
}