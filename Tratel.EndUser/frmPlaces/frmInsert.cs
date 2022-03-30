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
using Tratel.Contracts;
using Tratel.Data.Managers;
using Tratel.Entities.Customer;

namespace Tratel.EndUser.frmPlaces
{
    public partial class frmInsert : Form
    {
        public frmInsert()
        {
            InitializeComponent();
            IsOpen = true;
        }

        public static bool IsOpen { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var country = cmbCountries.SelectedItem as GuidOptionDto;
            var context = ConnectionManager.GetDbContext();
            var place = new Place();
            {
                place.Name = txtName.Text;
                place.Address = txtAddress.Text;
                place.Phone = txtAddress.Text;
                place.Type = (PlaceType)(cmbType.SelectedIndex);
                place.CreatedAt = DateTime.Now;
                place.ModifiedAt = DateTime.Now;
                place.TownId = country.Id;
            };

            context.Places.Add(place);
            context.SaveChanges();
            this.Close();
        }

        private void frmInsert_Load(object sender, EventArgs e)
        {
            cmbType.DataSource = Enum.GetValues(typeof(PlaceType));
            var lookups = new LookUpRepository();
            cmbCountries.DataSource = lookups.GetNationalities();
            cmbCountries.DisplayMember = nameof(GuidOptionDto.Text);
        }

        private void frmInsert_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsOpen = false;
        }
    }
}
