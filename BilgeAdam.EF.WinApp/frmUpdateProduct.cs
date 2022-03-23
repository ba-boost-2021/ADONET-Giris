using BilgeAdam.EF.Common;
using BilgeAdam.EF.Common.Entities;
using BilgeAdam.EF.WinApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.EF.WinApp
{
    public partial class frmUpdateProduct : Form
    {
        public frmUpdateProduct(Product product)
        {
            InitializeComponent();
            Product = product;
        }

        public Product Product { get; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var category = cmbCategory.SelectedItem as ComboBoxItem;
            var supplier = cmbSupplier.SelectedItem as ComboBoxItem;
            using (var context = new NorthwindDbContext())
            {
                var product = context.Products.FirstOrDefault(x => x.ProductID == Product.ProductID && !x.IsDeleted);
                //var product = context.Products.Where(x => x.ProductID == Product.ProductID && !x.IsDeleted).First[OrDefault]();
                if (product == null)
                {
                    return;
                }

                product.ProductName = txtProductName.Text;
                product.UnitsInStock = Convert.ToInt16(nudStock.Value);
                product.UnitPrice = nudPrice.Value;
                product.CategoryId = category.Id;
                product.SupplierID = supplier.Id;

                context.SaveChanges(); // Bir önceki işlemi veritabanına yansıt
            }
        }

        private void frmNewProduct_Load(object sender, EventArgs e)
        {
            using (var context = new NorthwindDbContext())
            {
                //SELECT c.CategoryID AS Id, c.CategoryName AS Name FROM Categories c
                cmbCategory.DataSource = context.Categories
                                                .Select(c => new ComboBoxItem
                                                {
                                                    Id = c.CategoryId,
                                                    Name = c.CategoryName
                                                }).ToList();
                //SELECT s.SupperlierID AS Id, s.ContactName AS Name FROM Suppliers s
                cmbSupplier.DataSource = context.Suppliers
                                                .Select(s => new ComboBoxItem
                                                {
                                                    Id = s.SupplierID,
                                                    Name = s.CompanyName
                                                }).ToList();
                cmbCategory.DisplayMember = nameof(ComboBoxItem.Name);
                cmbSupplier.DisplayMember = nameof(ComboBoxItem.Name);

                cmbCategory.SelectedItem = (cmbCategory.DataSource as List<ComboBoxItem>).First(f => f.Id == Product.CategoryId);
                cmbSupplier.SelectedItem = (cmbSupplier.DataSource as List<ComboBoxItem>).First(f => f.Id == Product.SupplierID);
                txtProductName.Text = Product.ProductName;
                nudPrice.Value = Product.UnitPrice ?? 0; //COALESCE
                nudStock.Value = Product.UnitsInStock ?? 0;
            }
        }
    }
}
