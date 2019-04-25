using Support.ViewModel;
using System.Windows.Forms;

namespace InsurenceCard
{
    public partial class IdentityCardShow : Form
    {
        private IdentityCardShowViewModel _identityCardShowViewModel;

        public IdentityCardShow(IdentityCardShowViewModel identityCardShowViewModel)
        {
            InitializeComponent();
            _identityCardShowViewModel = identityCardShowViewModel;
        }

        private void BindControls()
        {
            txtBxFirstName.DataBindings.Add(nameof(txtBxFirstName.Text),
                _identityCardShowViewModel,
                nameof(_identityCardShowViewModel.FirstName),
                true,
                DataSourceUpdateMode.OnValidation);

            txtBxLastName.DataBindings.Add(nameof(txtBxLastName.Text),
                _identityCardShowViewModel,
                nameof(_identityCardShowViewModel.LastName),
                true,
                DataSourceUpdateMode.OnValidation);

            txtBxPersonalID.DataBindings.Add(nameof(txtBxPersonalID.Text),
                _identityCardShowViewModel,
                nameof(_identityCardShowViewModel.PersonIdNumber),
                true,
                DataSourceUpdateMode.OnValidation);

            txtBxBirthDate.DataBindings.Add(nameof(txtBxBirthDate.Text),
                _identityCardShowViewModel,
                nameof(_identityCardShowViewModel.GetDateOfBirth),
                true,
                DataSourceUpdateMode.OnValidation);

            txtBxValidationDate.DataBindings.Add(nameof(txtBxValidationDate.Text),
                _identityCardShowViewModel,
                nameof(_identityCardShowViewModel.ValidationDate),
                true,
                DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
