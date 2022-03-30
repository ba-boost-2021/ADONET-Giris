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
using Tratel.Contracts.Places;
using Tratel.Data.Managers;

namespace Tratel.EndUser
{
    public partial class frmPlaceList : Form
    {
        private PlaceRepository service;

        public frmPlaceList()
        {
            InitializeComponent();
            service = new PlaceRepository();
        }
     

        private void frmPlaceList_Load(object sender, EventArgs e)
        {
            dgvPlaces.DataSource = service.GetPlace();
        }


        private void dgvPlaces_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point cp = PointToClient(Cursor.Position);
                cmsPlace.Show(dgvPlaces, new Point(cp.X-8, cp.Y-50));
            }
        }

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            var selectedItem = service.GetPlace()[dgvPlaces.CurrentRow.Index];
            var frmUpdate = new frmUpdate(selectedItem);
            frmUpdate.ShowDialog();
            dgvPlaces.DataSource = service.GetPlace();
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            var context = ConnectionManager.GetDbContext();
            var selectedItem = service.GetPlace()[dgvPlaces.CurrentRow.Index];
            var place = context.Places.Where(x => x.Name == selectedItem.Name).FirstOrDefault();
            context.Places.Remove(place);
            context.SaveChanges();
            dgvPlaces.DataSource = service.GetPlace();
        }

        private void btnAddPlace_Click(object sender, EventArgs e)
        {
            if (frmPlaces.frmInsert.IsOpen)
            {
                return;
            }
            var frmInsert = new frmPlaces.frmInsert();
            frmInsert.FormClosed += FrmInsert_FormClosed;
            frmInsert.MdiParent = this.MdiParent;
            frmInsert.Show();
        }

        private void FrmInsert_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPlaces.frmInsert)sender).FormClosed -= FrmInsert_FormClosed;
            dgvPlaces.DataSource = service.GetPlace();
        }
    }
}
