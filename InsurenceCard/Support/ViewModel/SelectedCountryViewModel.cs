using Support.Model;
using Support.Service;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Support.ViewModel
{
    public class SelectedCountryViewModel : INotifyPropertyChanged, ISelectedCountryViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string _personIdNumber;
        private DateTime _getDateOfBirth;
        private DateTime _validationDate;

        public string PersonIdNumber
        {
            get => _personIdNumber;
            set
            {
                _personIdNumber = value;
                GetDateOfBirth = _selectedCountryService.GetDateOfBirth(_personIdNumber);
                //NotifyPropertyChanged();
            }
        }
        public DateTime GetDateOfBirth
        {
            get => _getDateOfBirth;
            set
            {
                _getDateOfBirth = value;
            }
        }

        public DateTime ValidationDate
        {
            get => _validationDate;
            set
            {
                _validationDate = value;
                NotifyPropertyChanged();
            }
        }

        private SelectedCountryService _selectedCountryService;


        public SelectedCountryViewModel(SelectedCountryService selectedCountryService)
        {
            _selectedCountryService = selectedCountryService;
        }

        public void GenerateValidationDate()
        {
            ValidationDate = _selectedCountryService.GenerateValidationDate();
            NotifyPropertyChanged();
        }


        public User GetUser()
        {
            return new User()
            {
                Id = 1,
                FirstName = FirstName,
                LastName = LastName,
                BirthDate = GetDateOfBirth,
                PersonIdNumber = PersonIdNumber,
                ValidFrom = ValidationDate
            };
        }

        public void SaveInsuranceCard()
        {

        }

        #region NotifypropChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
