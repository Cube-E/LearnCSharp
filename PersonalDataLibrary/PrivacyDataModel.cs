using System;

namespace PersonalDataLibary
{ 
    /// <summary>
    /// Represents a user's personal request for privacy.
    /// </summary>
    public class PrivacyDataModel
    {
        /// <summary>
        /// Whether the privacy notice has been requested or not.
        /// </summary>
        public bool privacyNotice { get; set; }
        public String ownerInitials { get; set; }
        public String dateRequestReceived { get; set; }
    }
}
