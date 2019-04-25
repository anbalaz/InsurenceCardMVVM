using Support.ViewModel;
using System;
using System.Windows.Forms;

namespace InsurenceCard
{
    public partial class FrmCreateInsuranceCard : Form
    {
        ISelectedCountryViewModel _selectedCountryViewModel;
        public FrmCreateInsuranceCard(ISelectedCountryViewModel selectedCountryViewModel)
        {
            InitializeComponent();
            _selectedCountryViewModel = selectedCountryViewModel;
            BindControls();
        }

        private void BindControls()
        {
            txtBxFirstName.DataBindings.Add(nameof(txtBxFirstName.Text),
                _selectedCountryViewModel,
                nameof(_selectedCountryViewModel.FirstName),
                true,
                DataSourceUpdateMode.OnValidation);

            txtBxLastName.DataBindings.Add(nameof(txtBxLastName.Text),
                _selectedCountryViewModel,
                nameof(_selectedCountryViewModel.LastName),
                true,
                DataSourceUpdateMode.OnValidation);

            txtBxPersonalID.DataBindings.Add(nameof(txtBxPersonalID.Text),
                _selectedCountryViewModel,
                nameof(_selectedCountryViewModel.PersonIdNumber),
                true,
                DataSourceUpdateMode.OnValidation);

            txtBxBirthDate.DataBindings.Add(nameof(txtBxBirthDate.Text),
                _selectedCountryViewModel,
                nameof(_selectedCountryViewModel.GetDateOfBirth),
                true,
                DataSourceUpdateMode.OnValidation);

            txtBxValidationDate.DataBindings.Add(nameof(txtBxValidationDate.Text),
                _selectedCountryViewModel,
                nameof(_selectedCountryViewModel.ValidationDate),
                true,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void bttnGenerate_Click(object sender, EventArgs e)
        {
            _selectedCountryViewModel.GenerateValidationDate();
        }

        private void bttnOK_Click(object sender, EventArgs e)
        {
            using (IdentityCardShow newFrm = new IdentityCardShow(new IdentityCardShowViewModel(_selectedCountryViewModel.GetUser())))
            {
                newFrm.ShowDialog();
            }
        }
    }
}