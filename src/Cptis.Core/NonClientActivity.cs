using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents activities conducted that do not involve direct client interaction.
    /// </summary>
    public class NonClientActivity
    {
        /// <summary>
        /// Unique identifier for the non-client activity.
        /// </summary>
        public int NonClientActivityId { get; set; }

        /// <summary>
        /// Name of the provider associated with the activity.
        /// </summary>
        public string NcProvider { get; set; }

        /// <summary>
        /// Identifier for the provider associated with the activity.
        /// </summary>
        public int ProviderId { get; set; }

        /// <summary>
        /// Date when the non-client activity occurred.
        /// </summary>
        public DateTime? NcActivityDate { get; set; }

        /// <summary>
        /// Description of the activity performed.
        /// </summary>
        public string NcActivitiy { get; set; }

        /// <summary>
        /// CPT office responsible for the activity.
        /// </summary>
        public string CptOffice { get; set; }

        /// <summary>
        /// Date when the record was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Date when the record was last updated.
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// First name of the user who performed the activity.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Last name of the user who performed the activity.
        /// </summary>
        public string UserLastName { get; set; }

        /// <summary>
        /// CE (Continuing Education) details related to the activity.
        /// </summary>
        public string CE { get; set; }

        /// <summary>
        /// Hours spent on the activity.
        /// </summary>
        public string Hours { get; set; }

        /// <summary>
        /// Type of activity conducted.
        /// </summary>
        public string TypeActivity { get; set; }

        /// <summary>
        /// Audience for the activity.
        /// </summary>
        public string Audience { get; set; }

        /// <summary>
        /// Indicates whether the record is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Navigation property for the associated provider.
        /// </summary>
        public virtual Provider Provider { get; set; }
    }
}
