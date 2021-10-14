using Microsoft.Extensions.Logging;
using PersonalDataLibrary.Models;
using PersonalDataLibrary.Utility;
using System;

namespace PersonalDataLibrary.Validators
{
    public class PersonalDataValidator
    {
        private readonly ILogger<PersonalDataValidator> _logger;
        public  PersonalDataModel getInstance (
            String firstName,
            String lastName ) {

            if (!validateInfo (
                firstName,
                lastName)) {

                return null;
            }
            return new PersonalDataModel (firstName, lastName);
        }
        public PersonalDataValidator(ILogger<PersonalDataValidator> logger = null)
        {
            //personalData = new PersonalDataModel();
            _logger = logger;
        }

        private bool validateInfo(string firstName, string lastName) {
            bool isValid = true;
            _logger.LogInformation ("Validating user");
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
