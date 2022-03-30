using Tratel.Common.Services.Repositories;
using Tratel.Contracts;
using Tratel.Data.Managers;

namespace Tratel.EndUser.LookUpTypes;

public partial class frmLookUpTypes : Form
{
    public LookUpTypeRepository Repository { get; set; }
    public frmLookUpTypes()
    {
        InitializeComponent();
        Repository = new LookUpTypeRepository();
        LookUpTypeEventManager.LookUpTypeEvents.OnLookUpTypeAdded += LookUpTypeEvents_OnLookUpTypeAdded;
    }

    private void LookUpTypeEvents_OnLookUpTypeAdded()
    {
        frmLookUpTypes_Load(null, null);
    }

    private void frmLookUpTypes_Load(object sender, EventArgs e)
    {
        dgvLookUpTypes.DataSource = Repository.GetAllTypes();
    }

    private void cmsDeleteLookUpType_Click(object sender, EventArgs e)
    {
        var selectedTypeName = Convert.ToString(dgvLookUpTypes.CurrentRow.Cells[1].Value);

        var result = Repository.DeleteSelectedType(selectedTypeName);

        if (result)
        {
            MessageBox.Show("Tip Silindi", "Tratel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Tip Silinemedi", "Tratel", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void dgvLookUpTypes_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            Point cp = PointToClient(Cursor.Position);
            cmsLookUpTypes.Show(dgvLookUpTypes, new Point(cp.X - 8, cp.Y - 50));
        }
    }

    private void cmsEditLookUpType_Click(object sender, EventArgs e)
    {
        txtName.Text = Convert.ToString(dgvLookUpTypes.CurrentRow.Cells[1].Value);
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {

        var lookUps = dgvLookUpTypes.SelectedRows[0].DataBoundItem as GuidOptionDto;
        var strings = txtName.Text;
        if (strings == null)
        {
            return;
        }
        var result = Repository.UpdateLookUpType(lookUps.Id, strings);
        if (result == false)
        {
            MessageBox.Show("Güncelleme Gerçekleştirilemedi", "Tratel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        dgvLookUpTypes.DataSource = null;
        dgvLookUpTypes.DataSource = Repository.GetAllTypes();
        MessageBox.Show("Güncelleme Başarılı", "Tratel", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
    }
}
