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
            using (var context = ConnectionManager.GetDbContext())
            {
                var user = context.Users.SingleOrDefault(i => i.Id == selected.Id);
                if (user == null)
                {
                    return;
                }
                context.Users.Remove(user);
                context.SaveChanges(); 
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = context.Users.ToList();
            }
        }
    }
}
