using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class NursingAssessmentSystem
    {
        /// <summary>
        /// Unique identifier for the system assessment record.
        /// </summary>
        public int NursingAssessmentSystemId { get; set; }

        /// <summary>
        /// Reference to the associated Nursing Assessment.
        /// </summary>
        public int NursingAssessmentId { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Status of eye and vision health.
        /// </summary>
        public string EyeVisionStatus { get; set; }

        /// <summary>
        /// Details about eye and vision health.
        /// </summary>
        public string EyeVision { get; set; }

        /// <summary>
        /// Status of ear and hearing health.
        /// </summary>
        public string EarHearingStatus { get; set; }

        /// <summary>
        /// Details about ear and hearing health.
        /// </summary>
        public string EarHearing { get; set; }

        /// <summary>
        /// Status of nose and throat health.
        /// </summary>
        public string NoseThroatStatus { get; set; }

        /// <summary>
        /// Details about nose and throat health.
        /// </summary>
        public string NoseThroat { get; set; }

        /// <summary>
        /// Status of oral and dental health.
        /// </summary>
        public string OralDentalStatus { get; set; }

        /// <summary>
        /// Details about oral and dental health.
        /// </summary>
        public string OralDental { get; set; }

        /// <summary>
        /// Status of respiratory health.
        /// </summary>
        public string RespiratoryStatus { get; set; }

        /// <summary>
        /// Details about respiratory health.
        /// </summary>
        public string Respiratory { get; set; }

        /// <summary>
        /// Status of cardiovascular health.
        /// </summary>
        public string CardioVascularStatus { get; set; }

        /// <summary>
        /// Details about cardiovascular health.
        /// </summary>
        public string CardioVascular { get; set; }

        /// <summary>
        /// Status of gastrointestinal health.
        /// </summary>
        public string GastroIntestinalStatus { get; set; }

        /// <summary>
        /// Details about gastrointestinal health.
        /// </summary>
        public string GastroIntestinal { get; set; }

        /// <summary>
        /// Status of genitourinary health.
        /// </summary>
        public string GenitourinaryStatus { get; set; }

        /// <summary>
        /// Details about genitourinary health.
        /// </summary>
        public string Genitourinary { get; set; }

        /// <summary>
        /// Status of endocrine system health.
        /// </summary>
        public string EndocrineStatus { get; set; }

        /// <summary>
        /// Details about endocrine system health.
        /// </summary>
        public string Endocrine { get; set; }

        /// <summary>
        /// Status of dermatologic health.
        /// </summary>
        public string DermatologicStatus { get; set; }

        /// <summary>
        /// Details about dermatologic health.
        /// </summary>
        public string Dermatologic { get; set; }

        /// <summary>
        /// Status of musculoskeletal health.
        /// </summary>
        public string MusculoSkeletalStatus { get; set; }

        /// <summary>
        /// Details about musculoskeletal health.
        /// </summary>
        public string MusculoSkeletal { get; set; }

        /// <summary>
        /// Status of hematologic health.
        /// </summary>
        public string HematologicStatus { get; set; }

        /// <summary>
        /// Details about hematologic health.
        /// </summary>
        public string Hematologic { get; set; }

        /// <summary>
        /// Status of neurological health.
        /// </summary>
        public string NeurologicalStatus { get; set; }

        /// <summary>
        /// Details about neurological health.
        /// </summary>
        public string Neurological { get; set; }

        /// <summary>
        /// Status of developmental health.
        /// </summary>
        public string DevelopmentStatus { get; set; }

        /// <summary>
        /// Details about developmental health.
        /// </summary>
        public string Development { get; set; }

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
