using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tratel.Common.Enums;
using Tratel.Common.Services.Repositories;
using Tratel.Contracts.Places;
using Tratel.Data.Managers;

namespace Tratel.EndUser
{
    public partial class frmUpdate : Form
    {
        private PlaceListDto selectedItem;

        public frmUpdate(PlaceListDto selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            txtName.Text = selectedItem.Name;
            txtAddress.Text = selectedItem.Address;
            txtPhone.Text = selectedItem.Phone;
            txtTown.Text = selectedItem.Town.ToString();    
            cmbType.DataSource = Enum.GetValues(typeof(PlaceType));
            cmbType.SelectedItem = selectedItem.Type;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var type = cmbType.SelectedItem;
            var context = ConnectionManager.GetDbContext();
          
            var place = context.Places.FirstOrDefault(x => x.Name==selectedItem.Name );
           
            if (place == null)
            {
                return;
            }
            
            place.Name = txtName.Text;
            place.Address=txtAddress.Text;
            place.Town.Name = txtTown.Text; 
            place.Phone=txtAddress.Text;
            place.Type= (PlaceType)(cmbType.SelectedIndex);
            context.SaveChanges();
            
            this.Close();
        }
    }
}
