using System;

namespace PersonalDataLibary
{ 
    /// <summary>
    /// Represents a user's personal request/approval for private information to be utilized for data analytics and app improvements.
    /// </summary>
    public class PrivacyDataModel
    {
        /// <summary>
        /// User's approval for data to be shared.
        /// </summary>
        public bool shareData { get; set; }
        /// <summary>
        /// User's request for private data stored in database
        /// </summary>
        public bool privateDataRequest { get; set; }
        /// <summary>
        /// Computer generated timestamp of data request
        /// </summary>
        public String dateRequestReceived { get; set; }
        /// <summary>
        /// User's identification verification for internal approval for data release authorization.
        /// </summary>
        public String userDriverLicense { get; set; }
    }
}
