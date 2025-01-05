using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents family details associated with a registration.
    /// </summary>
    public class RegistrationFamily
    {
        /// <summary>
        /// Unique identifier for the registration family record.
        /// </summary>
        public int RegistrationFamilyId { get; set; }

        /// <summary>
        /// Identifier for the associated family demographic.
        /// </summary>
        public int FamilyDemographicId { get; set; }

        /// <summary>
        /// Identifier for the associated client demographic.
        /// </summary>
        public int ClientDemographicId { get; set; }

        /// <summary>
        /// Identifier for the associated registration.
        /// </summary>
        public int RegistrationId { get; set; }

        /// <summary>
        /// Alleged perpetrator information, if applicable.
        /// </summary>
        public string AllegedPerpetrator { get; set; }

        /// <summary>
        /// Unique identifier for the client.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Unique identifier for the family.
        /// </summary>
        public string FamilyID { get; set; }

        /// <summary>
        /// Case number associated with the family record.
        /// </summary>
        public string CaseNumber { get; set; }

        /// <summary>
        /// Sequence number for the registration.
        /// </summary>
        public string RegistrationSequenceNumber { get; set; }

        /// <summary>
        /// Relationship of the family member to the client.
        /// </summary>
        public string Relation { get; set; }

        /// <summary>
        /// Navigation property for the associated client demographic.
        /// </summary>
        public virtual ClientDemographic ClientDemographic { get; set; }

        /// <summary>
        /// Navigation property for the associated registration.
        /// </summary>
        public virtual Registration Registration { get; set; }
    }
}
