using PersonalDataLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDataLibrary.Controller
{
    class PersonalDataController
    {
        public bool getFirstName(string firstName)
        {
            return StringUtility.validateName(firstName);

        }

    }
}
