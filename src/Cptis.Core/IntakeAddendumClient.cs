using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class IntakeAddendumClient
    {
        public int IntakeAddendumClientId { get; set; }
        public int IntakeId { get; set; }
        public int IntakeAddendumId { get; set; }
        public int ClientDemographicId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public ClientId ClientId { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool IsDeleted { get; set; }
        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        // Navigation properties
        public IntakeAddendum IntakeAddendum { get; set; }
        public ClientDemographic ClientDemographic { get; set; }
    }
}
