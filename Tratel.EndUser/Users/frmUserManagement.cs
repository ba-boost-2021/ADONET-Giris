using Tratel.Common.Services.Repositories;
using Tratel.Contracts.Users;
using Tratel.Data.Managers;

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
            updateForm.ShowDialog();



        }
    }
}
