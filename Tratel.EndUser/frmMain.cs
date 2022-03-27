using Tratel.EndUser.Users;

namespace Tratel.EndUser
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void msbUserManagement_Click(object sender, EventArgs e)
        {
            OpenForm<frmUserManagement>();
        }

        private void OpenForm<T>() where T: Form
        {
            var f = Activator.CreateInstance<T>();
            f.MdiParent = this;
            f.Show();
        }

        private void msbNewUser_Click(object sender, EventArgs e)
        {
            OpenForm<frmNewUser>();
        }
    }
}