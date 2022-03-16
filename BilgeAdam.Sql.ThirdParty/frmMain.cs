using BilgeAdam.Sql.ThirdParty.HR;
using BilgeAdam.Sql.ThirdParty.Production;

namespace BilgeAdam.Sql.ThirdParty
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void msbSalesHistory_Click(object sender, EventArgs e)
        {
            
        }

        private void msbStocks_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmProducts>();
        }

        private void OpenChildForm<T>() where T : Form
        {
            var f = Activator.CreateInstance<T>();
            f.MdiParent = this;
            f.Show();
        }

        private void msbEmployees_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmEmployees>();
        }
    }
}