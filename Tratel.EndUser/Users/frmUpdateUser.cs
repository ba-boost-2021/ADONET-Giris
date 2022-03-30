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
    public partial class frmUpdateUser : Form
    {
        private UserListDto User;
        private UserRepository userRepository;
        private LookUpRepository lookUpRepository;

        public frmUpdateUser(UserListDto user)
        {
            InitializeComponent();
            this.User = user;
            userRepository = new UserRepository();
            lookUpRepository = new LookUpRepository();
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            var userId = User.Id;

            var updateUser = userRepository.GetNewUserDto(userId);


            SetTextData(updateUser);
            SetComboBox(updateUser);

            
        }

        private void SetComboBox(NewUserDto updateUser)
        {
            cmbNationality.DataSource = lookUpRepository.GetNationalities();

            cmbNationality.DisplayMember = nameof(Text);

        }

        private void SetTextData(NewUserDto updateUser)
        {
            txtFullName.Text = updateUser.FullName;
            txtMail.Text = updateUser.Mail;
            txtPassport.Text = updateUser.PassportNumber;
            txtUserName.Text = updateUser.UserName;
            txtPassword.Text = updateUser.Password;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var nationality = cmbNationality.SelectedItem as OptionDto<Guid>;
            var user = new UpdateUserDto { 
                FullName=txtFullName.Text,
                Mail=txtMail.Text,
                PassportNumber=txtPassport.Text,
                UserName=txtUserName.Text,
                Password=txtPassword.Text,
                NationalityId=nationality.Id,
                ModifiedDate= DateTime.Now,

            };

           var result = userRepository.UpdateUser(user , User.Id);




            if (result == false)
            {   
                MessageBox.Show("Kullanıcı güncellenemedi","Eror",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }
            MessageBox.Show("Kullanıcı Başarıyla Güncellendi.","Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult=DialogResult.OK;
            this.Close();
            return;

        }
    }
}
