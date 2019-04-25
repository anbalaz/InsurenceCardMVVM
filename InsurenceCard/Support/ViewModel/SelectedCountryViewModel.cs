using System;

namespace Support.ViewModel
{
    public class SelectedCountryViewModel : ISelectedCountryViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonIdNumber { get; set; }
        public DateTime ValidationDate { get; set; }

        public DateTime GetDateOfBirth()
        {
            return DateTime.MinValue;
        }

        public void SaveInsuranceCard()
        {

        }
    }
}
