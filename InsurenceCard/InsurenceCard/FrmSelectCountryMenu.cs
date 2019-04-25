using Support.ViewModel;
using System;
using System.Windows.Forms;

namespace InsurenceCard
{
    public partial class FrmSelectCountryMenu : Form
    {
        private ISelectedCountryViewModel _selectedCountryViewModel;
        public FrmSelectCountryMenu(ISelectedCountryViewModel selectedCountryViewModel)
        {
            InitializeComponent();
            _selectedCountryViewModel = selectedCountryViewModel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FrmCreateInsuranceCard newFrm = new FrmCreateInsuranceCard(_selectedCountryViewModel))
            {
                newFrm.ShowDialog();
            }
        }
    }
}
