namespace BilgeAdam.Sql.ThirdParty.HR
{
    partial class frmEmployees
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 151);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowTemplate.Height = 25;
            this.dgvEmployees.Size = new System.Drawing.Size(845, 358);
            this.dgvEmployees.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(56, 22);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(174, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(284, 22);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(193, 23);
            this.txtLastName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyadı";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(483, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(483, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "yyyy/MM/dd";
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(25, 73);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(205, 23);
            this.dtpBirthDate.TabIndex = 6;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.CustomFormat = "yyyy/MM/dd";
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHireDate.Location = new System.Drawing.Point(236, 75);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(174, 23);
            this.dtpHireDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giriş Tarihi";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(25, 122);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(174, 23);
            this.txtCity.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Şehir";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(236, 122);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(174, 23);
            this.txtCountry.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ülke";
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 521);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "frmEmployees";
            this.Text = "frmEmployees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvEmployees;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label1;
        private Label label2;
        private Button btnSearch;
        private Button btnSave;
        private DateTimePicker dtpBirthDate;
        private DateTimePicker dtpHireDate;
        private Label label3;
        private Label label4;
        private TextBox txtCity;
        private Label label5;
        private TextBox txtCountry;
        private Label label6;
    }
}