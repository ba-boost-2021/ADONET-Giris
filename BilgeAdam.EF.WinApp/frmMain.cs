using BilgeAdam.EF.Common;
using BilgeAdam.EF.Common.Entities;
using BilgeAdam.EF.WinApp.Models;

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
            using (var context = new NorthwindDbContext())
            {
                dgvProducts.DataSource = context.Products.ToList();
                //SELECT c.CategoryID AS Id, c.CategoryName AS Name FROM Categories c
                cmbCategories.DataSource = context.Categories
                                                  .Select(c => new ComboBoxItem
                                                  {
                                                      Id = c.CategoryId,
                                                      Name = c.CategoryName
                                                  }).ToList();
                //SELECT s.SupperlierID AS Id, s.ContactName AS Name FROM Suppliers s
                cmbSuppliers.DataSource = context.Suppliers
                                                 .Select(s => new ComboBoxItem
                                                 {
                                                     Id = s.SupplierID,
                                                     Name = s.CompanyName
                                                 }).ToList();

                cmbCategories.DisplayMember = nameof(ComboBoxItem.Name);
                cmbSuppliers.DisplayMember = nameof(ComboBoxItem.Name);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            using (var context = new NorthwindDbContext())
            {
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = context.Products.ToList();

                //SELECT * FROM Products
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new NorthwindDbContext())
            {
                var selected = cmbCategories.SelectedItem as Category;
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = context.Products
                                                .Where(f => f.CategoryId == selected.CategoryId)
                                                .ToList();

                //SELECT * FROM Products f WHERE f.CategoryId = @Id
            }
        }
    }
}