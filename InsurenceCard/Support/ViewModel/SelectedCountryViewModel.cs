using Support.Service;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Support.ViewModel
{
    public class SelectedCountryViewModel : ISelectedCountryViewModel, INotifyPropertyChanged
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string _personIdNumber;
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

        public DateTime ValidationDate { get; set; } = DateTime.Now;
        private SelectedCountryService _selectedCountryService;
        private DateTime _getDateOfBirth;


        public SelectedCountryViewModel(SelectedCountryService selectedCountryService)
        {
            _selectedCountryService = selectedCountryService;
        }

        //public DateTime GetDateOfBirth(string personIdNumber)
        //{
        //    return _selectedCountryService.GetDateOfBirth(personIdNumber);
        //}

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
