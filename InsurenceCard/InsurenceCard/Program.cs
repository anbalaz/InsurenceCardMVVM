using Support.Service;
using Support.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsurenceCard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SelectedCountryService selectedCountryService = new SelectedCountryService();
            ISelectedCountryViewModel selectedCountryViewModel = new SelectedCountryViewModel(selectedCountryService);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSelectCountryMenu(selectedCountryViewModel));
        }
    }
}
