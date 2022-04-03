using Tratel.Common.Services.Repositories;

namespace Tratel.EndUser.LookUpTypes
{
    public partial class frmNewLookUpType : Form
    {
        public LookUpTypeRepository repo { get; set; }
        public NewLookUpTypeDto data { get; set; }
        public frmNewLookUpType()
        {
            InitializeComponent();
            repo = new LookUpTypeRepository();
            data = new NewLookUpTypeDto();  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errP.Clear();
            if (!IsValid()) { return; }
            data.Name = txtName.Text;   
            data.CreateAt = DateTime.Now;
            data.ModifiedAt = DateTime.Now;
            if (IsExist()) { return; }

            var result = repo.CreateLookUpType(data);

            if (result)
            {

                MessageBox.Show("Tip Kaydı Oluşturuldu!", "Tratel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LookUpTypeEventManager.LookUpTypeEvents.LookUpTypeAdded();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tip Kaydı Oluşturulamadı!", "Tratel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, null);
            }
        }
        #region ValidationMethods
        bool IsValid()
        {
            int parsedValue;
            var isValid = true;
            if ((string.IsNullOrWhiteSpace(txtName.Text)))
            {
                isValid = false;
                errP.SetError(txtName, "Bu Alan Boş Bırakılamaz!");
            }
            if (int.TryParse(txtName.Text, out parsedValue))
            {
                isValid = false;
                errP.SetError(txtName, "Sadece Sayısal veri Girilemez");
            }
            return isValid;
        }
        bool IsExist()
        {
            var result = repo.CheckForExistMetaData(data);
            if (result)
            {
                errP.SetError(txtName, "Bu isimde MetaData mevcut!");
                return true;
            }
            return false;
        } 
        #endregion
    }
}
