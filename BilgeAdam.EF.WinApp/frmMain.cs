using BilgeAdam.EF.Common;
using BilgeAdam.EF.Common.Entities;

namespace BilgeAdam.EF.WinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var context = new NorthwindDbContext();
            dgvProducts.DataSource = context.Products.ToList();
            cmbCategories.DataSource = context.Categories.ToList();
            cmbSuppliers.DataSource = context.Suppliers.ToList();

            cmbCategories.DisplayMember = nameof(Category.CategoryName);
            cmbSuppliers.DisplayMember = nameof(Supplier.CompanyName);
        }
    }
}