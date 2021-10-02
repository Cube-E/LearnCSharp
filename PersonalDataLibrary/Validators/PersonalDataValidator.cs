using PersonalDataLibrary.Utility;
using System;

namespace PersonalDataLibrary.Validators
{
    public class PersonalDataValidator
    {
        //private PersonalDataModel personalData;
        public PersonalDataValidator()
        {
            //personalData = new PersonalDataModel();
        }

        public bool validateInfo(string firstName, string lastName) {
            bool isValid = true;
            if (!isValidFirstName(firstName)) {
                isValid = false;
            }
            if (!isValidLastName(lastName)) {
                isValid = false;
            }
            return isValid;
        }
        private bool isValidFirstName(string firstName) {
            if (StringUtility.isNullOrEmpty(firstName)) {
                return false;
            }

            if (StringUtility.containsInvalidCharacters(firstName)) {
                return false;
            }
            return true;
        }

        private bool isValidLastName(string lastName) {
            if (StringUtility.isNullOrEmpty(lastName)) {
                return false;
            }

            if (StringUtility.containsInvalidCharacters(lastName)) {
                return false;
            }
            return true;
        }
    }
}
