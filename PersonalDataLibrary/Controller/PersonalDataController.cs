using PersonalDataLibary;
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
        private PersonalDataModel personalData;
        public PersonalDataController()
        {
            personalData = new PersonalDataModel();
        }
        public bool getFirstName(string firstName)
        {
            if (StringUtility.isNullOrEmpty(firstName){
                //return an error message
            }

            if (StringUtility.ContainsValidCharacters(firstName){
                //return an error message
            }

            return true;
        }

    }
}
