using System;

namespace PersonalDataLibary
{
    /// <summary>
    /// Represents the contact data of a user.
    /// </summary>
    public class ContactDataModel
    {
        /// <summary>
        /// The phone number of the user.
        /// </summary>
        public String phoneNumber { get; set; }

        /// <summary>
        /// The opt in text option for a user.
        /// </summary>
        public bool optInTxtCommunication { get; set; }

        /// <summary>
        /// The opt in email option for a user.
        /// </summary>
        public bool optInEmailCommunication { get; set; }

        /// <summary>
        /// The fax of a user.
        /// </summary>
        public String fax { get; set; }

        /// <summary>
        /// The email of a user.
        /// </summary>
        public String email { get; set; }
    }
}
