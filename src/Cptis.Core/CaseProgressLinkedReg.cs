using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class CaseProgressLinkedReg
    {
        /// <summary>
        /// The system assigned unique identifier for the case progress linked registration
        /// </summary>
        public int CaseProgressLinkedRegId { get; set; }
        /// <summary>
        /// The FK to the registration
        /// </summary>
        public int RegistrationId { get; set; }
        /// <summary>
        /// FK to the case progress note
        /// </summary>
        public int CaseProgressId { get; set; }
        /// <summary>
        /// FK to the client demographic
        /// </summary>
        public int ClientDemographicId { get; set; }
        /// <summary>
        /// FK to a linked client demographic
        /// </summary>
        public int LinkedClientDemographicId { get; set; }
        /// <summary>
        /// Created Date of record
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// update date of record
        /// </summary>
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// user first name who updated record
        /// </summary>
        public string UserFirstName { get; set; }
        /// <summary>
        /// user last name who updated record
        /// </summary>
        public string UserLastName { get; set; }
        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Corresponding case progress note
        /// </summary>
        public CaseProgress CaseProgress { get; set; }
        /// <summary>
        /// corresponding registration
        /// </summary>
        public Registration Registration { get; set; }
        /// <summary>
        /// corresponding client demographic record
        /// </summary>
        public ClientDemographic ClientDemographic { get; set; }
    }
}
