using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support.Service
{
    public class SelectedCountryService
    {


        public DateTime GetDateOfBirth(string personId)
        {
            string year = personId.Substring(0, 2);
            string month = personId.Substring(2, 2);
            string day = personId.Substring(4, 2);

            DateTime dateOfBirth = DateTime.Parse($"19{year}-{month}-{day}");

            return dateOfBirth;
        }
    }
}
