using Support.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support.Service
{
    public class IdentityCardShowService
    {
        private User _user;

        public IdentityCardShowService(User user)
        {
            _user = user;
        }
    }
}