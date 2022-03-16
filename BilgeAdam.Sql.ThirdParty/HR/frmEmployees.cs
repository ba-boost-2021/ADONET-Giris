using BilgeAdam.Sql.ThirdParty.HR.Models;
using BilgeAdam.Sql.ThirdParty.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Sql.ThirdParty.HR
{
    public partial class frmEmployees : Form
    {
        private ConnectionManager connectionManager;
        private string queryRoot;
        public frmEmployees()
        {
            InitializeComponent();
            connectionManager = new ConnectionManager();
            queryRoot = "SELECT EmployeeID AS Id, FirstName, LastName, City, BirthDate, HireDate FROM Employees";
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = connectionManager.RunSelect<EmployeeDTO>(queryRoot);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var filterData = new EmployeeFilterParameter();
            var filter = new List<string>();
            if (!string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                filter.Add("FirstName = @Name");
                filterData.Name = txtFirstName.Text;
            }
            if (!string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                filter.Add("LastName = @Surname");
                filterData.Surname = txtLastName.Text;
            }
            if (filter.Count > 0)
            {
                var query = $"{queryRoot} WHERE {string.Join(" AND ", filter)}";
                dgvEmployees.DataSource = null;
                
                dgvEmployees.DataSource = connectionManager.RunSelect<EmployeeDTO>(query, filterData);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var @new = new NewEmployeeDTO
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                BirthDate = dtpBirthDate.Value,
                HireDate = dtpHireDate.Value
            };

            connectionManager.CreateNew(@"INSERT INTO Employees (FirstName, LastName, BirthDate, HireDate, Country, City) 
                                          VALUES (@FirstName, @LastName, @BirthDate, @HireDate, @Country, @City)", @new);
            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = connectionManager.RunSelect<EmployeeDTO>(queryRoot);
        }
    }
}
