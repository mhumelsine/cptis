using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class NursingAssessmentSexualAbuse
    {
        /// <summary>
        /// Unique identifier for the sexual abuse record.
        /// </summary>
        public int NursingAssessmentSexualAbuseId { get; set; }

        /// <summary>
        /// Reference to the associated Nursing Assessment.
        /// </summary>
        public int NursingAssessmentId { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Indicates if there was penile-vaginal contact.
        /// </summary>
        public bool PenileVaginal { get; set; }

        /// <summary>
        /// Indicates if there was oral-vaginal contact.
        /// </summary>
        public bool OralVaginal { get; set; }

        /// <summary>
        /// Indicates if there was forced masturbation.
        /// </summary>
        public bool ForcedMasturbation { get; set; }

        /// <summary>
        /// Indicates if there was penile-anal contact.
        /// </summary>
        public bool PenileAnal { get; set; }

        /// <summary>
        /// Indicates if there was oral-anal contact.
        /// </summary>
        public bool OralAnal { get; set; }

        /// <summary>
        /// Indicates if the alleged perpetrator is a close relative.
        /// </summary>
        public bool AllegedPerpCv { get; set; }

        /// <summary>
        /// Indicates if there was digital-vaginal contact.
        /// </summary>
        public bool DigitalVaginal { get; set; }

        /// <summary>
        /// Indicates if there was object-vaginal contact.
        /// </summary>
        public bool ObjectVaginal { get; set; }

        /// <summary>
        /// Indicates if there was fellatio.
        /// </summary>
        public bool Fellatio { get; set; }

        /// <summary>
        /// Indicates if there was digital-anal contact.
        /// </summary>
        public bool DigitalAnal { get; set; }

        /// <summary>
        /// Indicates if there was object-anal contact.
        /// </summary>
        public bool ObjectAnal { get; set; }

        /// <summary>
        /// Indicates if the child was exposed to pornography.
        /// </summary>
        public bool ExposureToPorn { get; set; }

        /// <summary>
        /// Indicates if the child was forced to participate in pornography.
        /// </summary>
        public bool ForcedParticipationPorn { get; set; }

        /// <summary>
        /// Identifies any sexually transmitted diseases (STDs) present.
        /// </summary>
        public string Std { get; set; }

        /// <summary>
        /// Specifies other sexual abuse details.
        /// </summary>
        public string OtherSexual { get; set; }

        /// <summary>
        /// The date and time the record was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// The date and time the record was last updated.
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// First name of the user who created or updated the record.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Last name of the user who created or updated the record.
        /// </summary>
        public string UserLastName { get; set; }

        /// <summary>
        /// Navigation property to the associated Nursing Assessment.
        /// </summary>
        public NursingAssessment NursingAssessment { get; set; }
    }
}
