namespace Tratel.EndUser.LookUpTypes
{
    partial class frmLookUpTypes
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
            this.dgvLookUpTypes = new System.Windows.Forms.DataGridView();
            this.cmsLookUpTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditLookUpType = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteLookUpType = new System.Windows.Forms.ToolStripMenuItem();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookUpTypes)).BeginInit();
            this.cmsLookUpTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLookUpTypes
            // 
            this.dgvLookUpTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLookUpTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLookUpTypes.ContextMenuStrip = this.cmsLookUpTypes;
            this.dgvLookUpTypes.Location = new System.Drawing.Point(11, 39);
            this.dgvLookUpTypes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvLookUpTypes.Name = "dgvLookUpTypes";
            this.dgvLookUpTypes.RowHeadersWidth = 82;
            this.dgvLookUpTypes.RowTemplate.Height = 41;
            this.dgvLookUpTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLookUpTypes.Size = new System.Drawing.Size(630, 294);
            this.dgvLookUpTypes.TabIndex = 0;
            this.dgvLookUpTypes.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLookUpTypes_CellMouseUp);
            // 
            // cmsLookUpTypes
            // 
            this.cmsLookUpTypes.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsLookUpTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditLookUpType,
            this.cmsDeleteLookUpType});
            this.cmsLookUpTypes.Name = "cmsLookUpTypes";
            this.cmsLookUpTypes.Size = new System.Drawing.Size(117, 48);
            // 
            // cmsEditLookUpType
            // 
            this.cmsEditLookUpType.Name = "cmsEditLookUpType";
            this.cmsEditLookUpType.Size = new System.Drawing.Size(116, 22);
            this.cmsEditLookUpType.Text = "Düzenle";
            this.cmsEditLookUpType.Click += new System.EventHandler(this.cmsEditLookUpType_Click);
            // 
            // cmsDeleteLookUpType
            // 
            this.cmsDeleteLookUpType.Name = "cmsDeleteLookUpType";
            this.cmsDeleteLookUpType.Size = new System.Drawing.Size(116, 22);
            this.cmsDeleteLookUpType.Text = "Sil";
            this.cmsDeleteLookUpType.Click += new System.EventHandler(this.cmsDeleteLookUpType_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(53, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "İsim :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(565, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // frmLookUpTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 346);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvLookUpTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmLookUpTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LookUp Types Menu";
            this.Load += new System.EventHandler(this.frmLookUpTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookUpTypes)).EndInit();
            this.cmsLookUpTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvLookUpTypes;
        private ContextMenuStrip cmsLookUpTypes;
        private ToolStripMenuItem cmsEditLookUpType;
        private ToolStripMenuItem cmsDeleteLookUpType;
        private TextBox txtName;
        private Label label1;
        private Button btnUpdate;
        private ErrorProvider errP;
    }
}