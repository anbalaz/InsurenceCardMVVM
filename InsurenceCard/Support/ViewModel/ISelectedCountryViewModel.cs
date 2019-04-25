using System;
using System.ComponentModel;
using Support.Model;

namespace Support.ViewModel
{
    public interface ISelectedCountryViewModel
    {
        string FirstName { get; set; }
        DateTime GetDateOfBirth { get; set; }
        string LastName { get; set; }
        string PersonIdNumber { get; set; }
        DateTime ValidationDate { get; set; }

        event PropertyChangedEventHandler PropertyChanged;

        void GenerateValidationDate();
        User GetUser();
        void SaveInsuranceCard();
    }
}