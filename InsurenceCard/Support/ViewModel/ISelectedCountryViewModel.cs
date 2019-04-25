using System;

namespace Support.ViewModel
{
    public interface ISelectedCountryViewModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int PersonIdNumber { get; set; }
        DateTime ValidationDate { get; set; }

        DateTime GetDateOfBirth();
        void SaveInsuranceCard();
    }
}