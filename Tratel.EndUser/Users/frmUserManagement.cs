using Tratel.Common.Services.Repositories;
using Tratel.Contracts.Users;

namespace Tratel.EndUser.Users
{
    public partial class frmUserManagement : Form
    {
        public frmUserManagement()
        {
            InitializeComponent();
            Repository = new UserRepository();
        }

        public UserRepository Repository { get; set; }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = Repository.GetUsers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var user = dgvUsers.SelectedRows[0].DataBoundItem as UserListDto;

            var updateForm = new frmUpdateUser(user);
            var result = updateForm.ShowDialog();
            if (result == DialogResult.OK)
            {

                dgvUsers.DataSource = null;
                dgvUsers.DataSource = Repository.GetUsers();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = dgvUsers.SelectedRows[0].DataBoundItem as UserListDto;
            if (selected == null)
            {
                return;
            }
            var result = MessageBox.Show($"{selected.UserName} isimli kullanıcıyı silmek istediğinizden emin misiniz?", "Kullanıcı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            Repository.DeleteUser(selected.Id);
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = Repository.GetUsers();
        }
    }
}