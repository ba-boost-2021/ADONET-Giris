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
using Tratel.Data.Managers;
using Tratel.Entities.Customer;

namespace Tratel.EndUser.frmPlaces
{
    public partial class frmInsert : Form
    {
        private Guid g;
        public frmInsert()
        {
            InitializeComponent();
            g = Guid.NewGuid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var context = ConnectionManager.GetDbContext();

            var type = cmbType.SelectedItem;

            var place = new Place();
            {
                place.Id = g;
                place.Name = txtName.Text;
                place.Address = txtAddress.Text;
                place.Phone = txtAddress.Text;
                place.Type = (PlaceType)(cmbType.SelectedIndex);
                place.CreatedAt = DateTime.Now;
                place.ModifiedAt = DateTime.Now;
                place.TownId = new Guid("3BD89135-077E-45F4-A071-DFDAAB192B0D");

            };

            context.Places.Add(place);
            context.SaveChanges();
            this.Close();
        }

        private void frmInsert_Load(object sender, EventArgs e)
        {
            cmbType.DataSource = Enum.GetValues(typeof(PlaceType));
            txtId.Text = g.ToString();
            txtTown.Text = "Turkiye";
        }
    }
}
