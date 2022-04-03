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
        FormArrangement(false); 
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
        var selectedType = dgvLookUpTypes.CurrentRow.DataBoundItem as GuidOptionDto;

        var result = Repository.DeleteSelectedType(selectedType);

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
        txtName.Text = (dgvLookUpTypes.CurrentRow.DataBoundItem as GuidOptionDto).Text;
        FormArrangement(true); 
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {

        var lookUps = dgvLookUpTypes.CurrentRow.DataBoundItem as GuidOptionDto;
        var strings = txtName.Text;
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            errP.SetError(txtName, "Bir İsim girmelisiniz!");
            return;
        }
        var result = Repository.UpdateLookUpType(lookUps.Id, strings);
        if (result == false)
        {
            MessageBox.Show("Güncelleme Gerçekleştirilemedi", "Tratel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        LookUpTypeEventManager.LookUpTypeEvents.LookUpTypeAdded();
        MessageBox.Show("Güncelleme Başarılı", "Tratel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        FormArrangement(false);
    }

    void FormArrangement(bool flag)
    {
        if (flag)
        {
            lblName.Visible = true;
            txtName.Visible = true;
            btnUpdate.Enabled = true;
            return;
        }
        lblName.Visible = false;
        txtName.Visible = false;
        btnUpdate.Enabled = false;
    }
}
