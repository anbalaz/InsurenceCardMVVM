using System;
using System.Windows.Forms;

namespace InsurenceCard
{
    public partial class FrmSelectCountryMenu : Form
    {
        public FrmSelectCountryMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FrmCreateInsuranceCard newFrm = new FrmCreateInsuranceCard())
            {
                newFrm.ShowDialog();
            }
        }
    }
}
