using System;

namespace PersonalDataLibary
{

    /// <summary>
    /// Represents all the personal data of a user.
    /// </summary>
    public class PersonalDataModel
    {
        /// <summary>
        /// The last name of the user.
        /// </summary>
        public String _lastName { get; set; }

        /// <summary>
        /// The first name of the user.
        /// </summary>
        public String _firstName { get; set; }

        /// <summary>
        /// The middle name of the user.
        /// </summary>
        public String _middleName { get; set; }

        /// <summary>
        /// The title of the user.
        /// </summary>
        public String _title { get; set; }

        /// <summary>
        /// The gender of the user.
        /// </summary>
        public String _gender { get; set; }

        /// <summary>
        /// The birthday of the user.
        /// </summary>
        public String _birthday { get; set; }

        /// <summary>
        /// The contact data of the user.
        /// </summary>
        public ContactDataModel _contactData { get; set; }

        /// <summary>
        /// The location data of the user.
        /// </summary>
        public LocationDataModel _locationData { get; set; }

        /// <summary>
        /// The privacy data of the user.
        /// </summary>
        public PrivacyDataModel _privacyData { get; set; }

    }

}
