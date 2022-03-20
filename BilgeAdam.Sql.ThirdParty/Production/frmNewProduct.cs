using BilgeAdam.Sql.ThirdParty.Managers;
using BilgeAdam.Sql.ThirdParty.Production.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilgeAdam.Sql.ThirdParty.Extensions;
using System.Data.SqlClient;
using BilgeAdam.Sql.ThirdParty.Events;

namespace BilgeAdam.Sql.ThirdParty.Production
{
    public partial class frmNewProduct : Form
    {
        private ConnectionManager connectionManager;
        private BindingList<ComboBoxItem> categories;
        private BindingList<ComboBoxItem> suppliers;
        public frmNewProduct()
        {
            InitializeComponent();
            connectionManager = new ConnectionManager();
            categories = new BindingList<ComboBoxItem>();
            suppliers = new BindingList<ComboBoxItem>();

            cmbCategories.DataSource = categories;
            cmbCategories.DisplayMember = nameof(ComboBoxItem.Name);
            cmbSuppliers.DataSource = suppliers;
            cmbSuppliers.DisplayMember = nameof(ComboBoxItem.Name);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var category = cmbCategories.SelectedItem as ComboBoxItem;
            var supplier = cmbSuppliers.SelectedItem as ComboBoxItem;
            var query = @"INSERT INTO Products 
                                (ProductName, UnitPrice, UnitsInStock, CategoryId, SupplierId)
                          VALUES
                                (@productName, @unitPrice, @unitsInStock, @categoryId, @supplierId)";
            if (CheckIfProductExist())
            {
                MessageBox.Show("Bu ürün daha önce kaydedildi", "Yeni Ürün", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var parameters = new List<SqlParameter>();
            parameters.Add("@productName", txtProductName.Text)
                      .Add("@unitPrice", nudUnitPrice.Value)
                      .Add("@unitsInStock", nudUnitsInStock.Value)
                      .Add("@categoryId", category.Id)
                      .Add("@supplierId", supplier.Id);

            connectionManager.Insert(query, parameters);
            MessageBox.Show("Kayıt Başarılı", "Yeni Ürün", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EventManager.ProductionEvents.ProductAdded();
            txtProductName.Clear();
            nudUnitPrice.Value = nudUnitPrice.Minimum;
            nudUnitsInStock.Value = nudUnitsInStock.Minimum;
            cmbCategories.SelectedIndex = 0;
            cmbSuppliers.SelectedIndex = 0;
        }

        private bool CheckIfProductExist()
        {
            var count = connectionManager.RunAggregation<int>($"SELECT COUNT(0) FROM Products WHERE ProductName = '{txtProductName.Text}'"); // SQL Injection örneği // Güvenlik zaafiyet (Security Vulnerability)
            return count > 0;
        }

        private void frmNewProduct_Load(object sender, EventArgs e)
        {
            LoadInitials();
        }

        private void LoadInitials()
        {
            suppliers.Clear();
            categories.Clear();
            var categoryQuery = "SELECT CategoryId AS Id, CategoryName AS Name FROM Categories";
            var loadedCategories = connectionManager.RunSelect<ComboBoxItem>(categoryQuery);
            categories.AddRange(loadedCategories);

            var supplierQuery = "SELECT SupplierId AS Id, CompanyName AS Name FROM Suppliers";
            var loadedSuppliers = connectionManager.RunSelect<ComboBoxItem>(supplierQuery);
            suppliers.AddRange(loadedSuppliers);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
