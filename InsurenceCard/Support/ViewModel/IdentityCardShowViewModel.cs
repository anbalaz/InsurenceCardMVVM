using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Support.Model;

namespace Support.ViewModel
{
    public class IdentityCardShowViewModel : INotifyPropertyChanged
    {
        private User _user;
        private string _firstName;
        public string FirstName
        {
            get =>_user.FirstName;
            set
            {
                _firstName = value;
                _user.FirstName = _firstName;
                NotifyPropertyChanged();
            }
        }
        public string LastName { get; set; }
        public string PersonIdNumber { get; set; }
        public DateTime GetDateOfBirth { get; set; }
        public DateTime ValidationDate { get; set; }

        public IdentityCardShowViewModel(User user)
        {
            _user = user;
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