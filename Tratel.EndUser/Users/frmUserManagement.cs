using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tratel.Common.Services.Repositories;
using Tratel.Data.Managers;

namespace Tratel.EndUser.Users
{
    public partial class frmUserManagement : Form
    {
        public frmUserManagement()
        {
            InitializeComponent();
            Repository = new UserRepository();
        }
        public UserRepository Repository { get; set; }
        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = Repository.GetUsers();
        }
    }
}
