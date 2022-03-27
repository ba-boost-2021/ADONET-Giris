using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tratel.Common.Services.Repositories;
using Tratel.Contracts;
using Tratel.Contracts.Users;

namespace Tratel.EndUser.Users
{
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            cmbNationality.DataSource = new LookUpRepository().GetNationalities();
            cmbNationality.DisplayMember = nameof(GuidOptionDto.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                return;
            }
            var nationality = cmbNationality.SelectedItem as GuidOptionDto;
            var repo = new UserRepository();
            var data = new NewUserDto
            {
                FullName = txtFullName.Text,
                Mail = txtMail.Text,
                PassportNumber = txtPassport.Text,
                Password = txtPassword.Text,
                UserName = txtUserName.Text,
                NationalityId = nationality.Id
            };
            var result = repo.CreateUser(data);
            if (result)
            {
                MessageBox.Show("Kullanıcı kaydı başarılı", "Tratel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kullanıcı kaydı tamalanamadı", "Tratel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsValid()
        {
            erp.Clear();
            var isValid = true;
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                isValid = false;
                SetError(txtFullName);
            }
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                isValid = false;
                SetError(txtMail);
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                isValid = false;
                SetError(txtPassword);
            }
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                isValid = false;
                SetError(txtUserName);
            }
            if (string.IsNullOrWhiteSpace(txtPassport.Text))
            {
                isValid = false;
                SetError(txtPassport);
            }

            return isValid;
        }

        private void SetError(Control control)
        {
            erp.SetError(control, "Boş geçilemez");
        }
    }
}
