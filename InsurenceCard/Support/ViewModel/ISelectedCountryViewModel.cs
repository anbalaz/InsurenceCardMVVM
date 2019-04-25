using System;

namespace Support.ViewModel
{
    public interface ISelectedCountryViewModel
    {
        string FirstName { get; set; }
        DateTime GetDateOfBirth { get; set; }
        string LastName { get; set; }
        string PersonIdNumber { get; set; }
        DateTime ValidationDate { get; set; }

        void SaveInsuranceCard();
    }
}