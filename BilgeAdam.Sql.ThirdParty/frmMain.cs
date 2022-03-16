using BilgeAdam.ADONET.Select.Production;
using BilgeAdam.ADONET.Select.Sales;

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
            OpenChildForm<frmSales>();
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
    }
}