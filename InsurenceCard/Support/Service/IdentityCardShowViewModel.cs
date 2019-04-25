using Support.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support.Service
{
    public class IdentityCardShowViewModel
    {
        private User _user;

        public IdentityCardShowViewModel(User user)
        {
            _user = user;
        }
    }
}