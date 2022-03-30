using Tratel.Common.Services.Repositories;

namespace Tratel.EndUser.LookUpTypes
{
    public partial class frmNewLookUpType : Form
    {
        public frmNewLookUpType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValid()) { return; }

            var data = new NewLookUpTypeDto
            {
                Name = txtName.Text,
                CreateAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
            };

            var repo = new LookUpTypeRepository();

            var result = repo.CreateLookUpType(data);

            if (result)
            {

                MessageBox.Show("Tip Kaydı Oluşturuldu!", "Tratel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LookUpTypeEventManager.LookUpTypeEvents.LookUpTypeAdded();
            }
            else
            {
                MessageBox.Show("Tip Kaydı Oluşturulamadı!", "Tratel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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
    }
}
