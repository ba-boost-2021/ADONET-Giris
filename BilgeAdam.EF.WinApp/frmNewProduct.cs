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
    public partial class frmNewProduct : Form
    {
        public frmNewProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var category = cmbCategory.SelectedItem as ComboBoxItem;
            var supplier = cmbSupplier.SelectedItem as ComboBoxItem;
            using (var context = new NorthwindDbContext())
            {
                var product = new Product
                {
                    ProductName = txtProductName.Text,
                    UnitPrice = nudPrice.Value,
                    UnitsInStock = Convert.ToInt16(nudStock.Value),
                    CategoryId = category?.Id, // ? -> SQL COALESCE ile aynı
                    SupplierID = supplier?.Id,
                };

                context.Products.Add(product); // SQL Injection'a karşı korumalıdır. Bu kısımda veri henüz server üzerindedi ve database'e aktarılmamıştır
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
            }
        }
    }
}
