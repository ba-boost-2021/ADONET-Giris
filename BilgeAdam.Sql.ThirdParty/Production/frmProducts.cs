using BilgeAdam.Sql.ThirdParty.Events;
using BilgeAdam.Sql.ThirdParty.Extensions;
using BilgeAdam.Sql.ThirdParty.Managers;
using BilgeAdam.Sql.ThirdParty.Production.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Sql.ThirdParty.Production
{
    public partial class frmProducts : Form
    {
        private readonly ConnectionManager connectionManager;
        private BindingList<StockProductModel> products;
        private BindingList<ComboBoxItem> categories;
        private BindingList<ComboBoxItem> suppliers;
        private int pageIndex;
        private int totalCount;

        public frmProducts()
        {
            InitializeComponent();
            dgvProducts.AutoGenerateColumns = false; // binding işlemi yapıldığında bind edilen class ın her property si için kolon oluşturma!
            connectionManager = new ConnectionManager();
            products = new BindingList<StockProductModel>();
            categories = new BindingList<ComboBoxItem>();
            suppliers = new BindingList<ComboBoxItem>();
            cmbItemCount.SelectedIndex = 0;
            dgvProducts.DataSource = products;
            EventManager.ProductionEvents.OnProductAdded += ProductionEvents_OnProductAdded; //  Event subscription

            cmbCategories.DataSource = categories;
            cmbCategories.DisplayMember = nameof(ComboBoxItem.Name);
            cmbSuppliers.DataSource = suppliers;
            cmbSuppliers.DisplayMember = nameof(ComboBoxItem.Name);
        }

        private void ProductionEvents_OnProductAdded()
        {
            LoadProducts();
            //productionEvents.OnProductAdded -= ProductionEvents_OnProductAdded; // Event unsubcription
        }

        public int PageIndex
        {
            get { return pageIndex; }
            set
            {
                pageIndex = value > 0 ? value : 0;
            }
        }

        public int TotalCount
        {
            get { return totalCount; }
            set
            {
                totalCount = value;
                txtTotal.Text = totalCount.ToString();
            }
        }

        public int PageSize
        {
            get
            {
                var selectedNumber = cmbItemCount.SelectedItem;
                if (selectedNumber == null)
                {
                    return Convert.ToInt32(cmbItemCount.Items[0]);
                }
                return Convert.ToInt32(selectedNumber);
            }
        }


        private void frmProducts_Load(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            LoadInitials();
            LoadProducts();
        }

        private void LoadProducts()
        {
            products.Clear();
            var countExpression = "COUNT(0)";
            var columns = @"p.ProductID AS Id, 
                            p.ProductName AS Name, 
                            p.UnitPrice AS Price, 
                            p.UnitsInStock AS Stock, 
                            c.CategoryName AS Category, 
                            s.CompanyName AS Company";
            var rawQuery = @"SELECT {0}
                           FROM Products p
                           INNER JOIN Categories c ON c.CategoryID = p.CategoryID 
                           INNER JOIN Suppliers s ON s.SupplierID  = p.SupplierID {1}";

            var offSetQuery = $"ORDER BY p.ProductID OFFSET {PageIndex * PageSize} ROWS FETCH NEXT {PageSize} ROWS ONLY";
            var countQuery = string.Format(rawQuery, countExpression, string.Empty);
            var dataQuery = string.Format(rawQuery, columns, offSetQuery);
            var result = connectionManager.RunSelect<StockProductModel>(dataQuery);
            foreach (var product in result)
            {
                products.Add(product);
            }
            TotalCount = connectionManager.RunAggregation<int>(countQuery);
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

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PageIndex--;
            LoadProducts();
            SetButtonAvailibilities();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PageIndex++;
            LoadProducts();
            SetButtonAvailibilities();
        }

        private void cmbItemCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
            SetButtonAvailibilities();
        }

        private void SetButtonAvailibilities()
        {
            btnNext.Enabled = TotalCount > PageSize * (PageIndex + 1);
            btnPrevious.Enabled = PageIndex > 0;
        }
    }
}
