using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Support.Model;

namespace Support.ViewModel
{
    public class IdentityCardShowViewModel
    {
        private User _user;
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string PersonIdNumber { get; set; }
        public DateTime GetDateOfBirth { get; set; }
        public DateTime ValidationDate { get; set; }



        public IdentityCardShowViewModel(User user)
        {
            _user = user;
        }


    }
}
