using System;
using MongoDB.Bson.Serialization.Attributes;

namespace PersonalDataLibrary.Models
{
    /// <summary>
    /// Represents the location data of a user.
    /// </summary>
    public class LocationDataModel
    {
        [BsonId]
        public Guid Id { get; set; }

        /// <summary>
        /// The primary address of a user.
        /// </summary>
        public String primaryAddress { get; set; }

        /// <summary>
        /// The secondary address of a user.
        /// </summary>
        public String secondaryAddress { get; set; }

        /// <summary>
        /// The city a user lives in.
        /// </summary>
        public String city { get; set; }

        /// <summary>
        /// The state a user lives in.
        /// </summary>
        public String state { get; set; }

        /// <summary>
        /// The postal code of a user.
        /// Change display name to zipcode when in the US.
        /// </summary>
        public String postalCode { get; set; }

        /// <summary>
        /// The country a user lives in.
        /// </summary>
        public String country { get; set; }
    }
}
