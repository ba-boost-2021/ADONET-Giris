using Tratel.Common.Services.Repositories;

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
    }
}
