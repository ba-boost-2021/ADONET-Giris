using BilgeAdam.EF.Common;
using BilgeAdam.EF.WinApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.EF.WinApp
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            var filters = Enum.GetValues(typeof(FilterBy))
                              .Cast<FilterBy>()
                              .Select(s => new FilterViewModel
                              {
                                  By = s,
                                  DisplayName = s.GetType().GetMember(s.ToString())
                                                 .First()
                                                 .GetCustomAttribute<DisplayAttribute>().Name
                              })
                              .ToList();
            cmbBy.DataSource = filters;
            cmbBy.DisplayMember = nameof(FilterViewModel.DisplayName);

            using (var context = new NorthwindDbContext())
            {
                dgvCustomers.DataSource = context.Customers
                                                 .Select(s => new CustomerViewModel
                                                 {
                                                     FullName = s.ContactName,
                                                     Company = s.CompanyName,
                                                     Country = s.Country,
                                                     City = s.City,
                                                     Phone = s.Phone
                                                 }).ToList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new NorthwindDbContext())
            {
                var query = context.Customers.AsQueryable();
                                   
                var selectedFilter = cmbBy.SelectedItem as FilterViewModel;
                switch (selectedFilter.By)
                {
                    case FilterBy.FullName:
                        query = query.Where(f => f.ContactName.StartsWith(txtFilter.Text));
                        break;
                    case FilterBy.City:
                        query = query.Where(f => f.City.StartsWith(txtFilter.Text));
                        break;
                    case FilterBy.Country:
                        query = query.Where(f => f.Country.StartsWith(txtFilter.Text));
                        break;
                    case FilterBy.Company:
                        query = query.Where(f => f.CompanyName.StartsWith(txtFilter.Text));
                        break;
                }

                var selectQuery = query.Select(s => new CustomerViewModel
                {
                    FullName = s.ContactName,
                    Company = s.CompanyName,
                    Country = s.Country,
                    City = s.City,
                    Phone = s.Phone
                });

                //SELECT Sorgusunun sonradan olması önemli, sorgunun oluşturulma yaklaşımı bakımından
                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = selectQuery.ToList();
            }
        }

        private void dgvCustomers_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }

    enum FilterBy
    {
        [Display(Name = "Adı Soyadı")]
        FullName = 1,
        [Display(Name = "Şehir")]
        City = 2,
        [Display(Name = "Ülke")]
        Country = 3,
        [Display(Name = "Firma")]
        Company = 4
    }

    class FilterViewModel
    {
        public FilterBy By { get; set; }
        public string DisplayName { get; set; }
    }
}
