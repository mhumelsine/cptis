using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class NursingAssessment
    {
        /// <summary>
        /// Primary Key for the Nursing Assessment.
        /// </summary>
        public int NursingAssessmentId { get; set; }

        /// <summary>
        /// Unique identifier for the nursing assessment.
        /// </summary>
        public string NursingAssessmentNum { get; set; }

        /// <summary>
        /// Associated abuse report number.
        /// </summary>
        public string AbuseReportNumber { get; set; }

        /// <summary>
        /// Associated client identifier.
        /// </summary>
        public ClientId ClientId { get; set; }

        /// <summary>
        /// Sequence number for the assessment.
        /// </summary>
        public string AssessmentSequenceNumber { get; set; }

        /// <summary>
        /// Sequence number for the registration.
        /// </summary>
        public string RegistrationSequenceNumber { get; set; }

        /// <summary>
        /// Indicates who accompanied the client.
        /// </summary>
        public string AccompaniedBy { get; set; }

        /// <summary>
        /// Relationship of the person accompanying the client.
        /// </summary>
        public string Relationship { get; set; }

        /// <summary>
        /// Whether a caregiver was present during the assessment.
        /// </summary>
        public string CareGiverPresent { get; set; }

        /// <summary>
        /// First name of the primary care provider.
        /// </summary>
        public string PcProviderFName { get; set; }

        /// <summary>
        /// Last name of the primary care provider.
        /// </summary>
        public string PcProviderLName { get; set; }

        /// <summary>
        /// Address of the primary care provider.
        /// </summary>
        public string PcProviderAddress { get; set; }

        /// <summary>
        /// City of the primary care provider.
        /// </summary>
        public string PcCity { get; set; }

        /// <summary>
        /// State of the primary care provider.
        /// </summary>
        public string PcState { get; set; }

        /// <summary>
        /// ZIP code of the primary care provider.
        /// </summary>
        public string PcZip { get; set; }

        /// <summary>
        /// Patient history obtained during the assessment.
        /// </summary>
        public string PatientHistoryPer { get; set; }

        /// <summary>
        /// Comments regarding acute medical conditions.
        /// </summary>
        public string AcuteMedicalComment { get; set; }

        /// <summary>
        /// Comments regarding chronic medical conditions.
        /// </summary>
        public string ChronicMedicalComment { get; set; }

        /// <summary>
        /// Details about the client's allergies.
        /// </summary>
        public string Allergies { get; set; }

        /// <summary>
        /// Details about the client's clinical history.
        /// </summary>
        public string ClinicalHistory { get; set; }

        /// <summary>
        /// Information about client immunizations.
        /// </summary>
        public string Immunizations { get; set; }

        /// <summary>
        /// Information about medications the client is taking.
        /// </summary>
        public string Medication { get; set; }

        /// <summary>
        /// Details about any treatment provided.
        /// </summary>
        public string Treatment { get; set; }

        /// <summary>
        /// Details about any medical equipment used.
        /// </summary>
        public string Equipment { get; set; }

        /// <summary>
        /// Client's height at the time of assessment.
        /// </summary>
        public string Height { get; set; }

        /// <summary>
        /// Client's weight at the time of assessment.
        /// </summary>
        public string Weight { get; set; }

        /// <summary>
        /// Head circumference measurement of the client.
        /// </summary>
        public string HeadCircumference { get; set; }

        /// <summary>
        /// Body Mass Index of the client.
        /// </summary>
        public string BMI { get; set; }

        /// <summary>
        /// Information about any photos taken during the assessment.
        /// </summary>
        public string Photos { get; set; }

        /// <summary>
        /// Indicates whether photos were taken using SteleMed.
        /// </summary>
        public string PhotoSteleMed { get; set; }

        /// <summary>
        /// Indicates whether digital photos were taken.
        /// </summary>
        public string PhotosDigital { get; set; }

        /// <summary>
        /// FDLE kit information, if applicable.
        /// </summary>
        public string FdleKit { get; set; }

        /// <summary>
        /// Indicates if diagrams were used during the assessment.
        /// </summary>
        public string Diagrams { get; set; }

        /// <summary>
        /// Diagrams related to head circumference.
        /// </summary>
        public string DiagramsHc { get; set; }

        /// <summary>
        /// Diagrams related to genital conditions.
        /// </summary>
        public string DiagramsGc { get; set; }

        /// <summary>
        /// Indicates whether crime information was given to the client.
        /// </summary>
        public string CrimesInfoGiven { get; set; }

        /// <summary>
        /// Nursing diagnosis made during the assessment.
        /// </summary>
        public string NursingDiagnosis { get; set; }

        /// <summary>
        /// Whether a medical referral was made.
        /// </summary>
        public string MedicalReferral { get; set; }

        /// <summary>
        /// Name of the medical referral provider.
        /// </summary>
        public string MedicalReferralName { get; set; }

        /// <summary>
        /// Indicates if early steps referral was provided.
        /// </summary>
        public string EarlyStepsReferral { get; set; }

        /// <summary>
        /// Name of the early steps referral provider.
        /// </summary>
        public string EarlyStepsReferralName { get; set; }

        /// <summary>
        /// Indicates whether another referral was made.
        /// </summary>
        public string OtherReferral { get; set; }

        /// <summary>
        /// Name of the other referral provider.
        /// </summary>
        public string OtherReferralName { get; set; }

        /// <summary>
        /// Signature of the provider conducting the assessment.
        /// </summary>
        public string ProviderSignature { get; set; }

        /// <summary>
        /// Date of the assessment.
        /// </summary>
        public DateTime? AssessmentDate { get; set; }

        /// <summary>
        /// Creation date of the record.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Last update date of the record.
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
        /// Date the provider signed the assessment.
        /// </summary>
        public DateTime? ProviderDate { get; set; }

        /// <summary>
        /// Foreign key to the associated abuse report.
        /// </summary>
        public int? AbuseReportId { get; set; }

        /// <summary>
        /// Foreign key to the associated client demographic.
        /// </summary>
        public int? ClientDemographicId { get; set; }

        /// <summary>
        /// Foreign key to the associated assessment.
        /// </summary>
        public int? AssessmentId { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Foreign key to the associated registration.
        /// </summary>
        public int? RegistrationId { get; set; }

        /// <summary>
        /// Indicates whether the record is marked as deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        // Navigation properties for relationships
        public AbuseReport AbuseReport { get; set; }
        public ClientDemographic ClientDemographic { get; set; }
        public Assessment Assessment { get; set; }
        public Registration Registration { get; set; }
        /// <summary>
        /// List of nursing assessment treatments
        /// </summary>
        public ICollection<NursingAssessmentTreatment> NursingAssessmentTreatments { get; set; }
        /// <summary>
        /// List of nursing assessment additional information
        /// </summary>
        public ICollection<NursingAssessmentAdditionalInfo> NursingAssessmentAdditionalInformation { get; set; }
        /// <summary>
        /// List of nursing assessment allergies
        /// </summary>
        public ICollection<NursingAssessmentAllergy> NursingAssessmentAllergies { get; set; }
        /// <summary>
        /// List of nursing assessment Clinicals
        /// </summary>
        public ICollection<NursingAssessmentClinical> NursingAssessmentClinicals { get; set; }
        /// <summary>
        /// List of nursing assessment Diagnoses
        /// </summary>
        public ICollection<NursingAssessmentDiagnosis> NursingAssessmentDiagnoses { get; set; }
        /// <summary>
        /// List of nursing assessment Equipment
        /// </summary>
        public ICollection<NursingAssessmentEquipment> NursingAssessmentEquipments { get; set; }
        /// <summary>
        /// List of nursing assessment Immunizations
        /// </summary>
        public ICollection<NursingAssessmentImmunization> NursingAssessmentImmunizations { get; set; }
        /// <summary>
        /// List of nursing assessment Labs
        /// </summary>
        public ICollection<NursingAssessmentLab> NursingAssessmentLabs { get; set; }
        /// <summary>
        /// List of nursing assessment Medications
        /// </summary>
        public ICollection<NursingAssessmentMedication> NursingAssessmentMedications { get; set; }
        /// <summary>
        /// List of nursing assessment Observations
        /// </summary>
        public ICollection<NursingAssessmentObservation> NursingAssessmentObservations { get; set; }
        /// <summary>
        /// List of nursing assessment who was present during exam
        /// </summary>
        public ICollection<NursingAssessmentPresentDuringExam> NursingAssessmentPresentDuringExams { get; set; }
        /// <summary>
        /// List of nursing assessment Risk Factors
        /// </summary>
        public ICollection<NursingAssessmentRiskFactor> NursingAssessmentRiskFactors { get; set; }
        /// <summary>
        /// List of nursing assessment Sexual Abuses
        /// </summary>
        public ICollection<NursingAssessmentSexualAbuse> NursingAssessmentSexualAbuses { get; set; }
        /// <summary>
        /// List of nursing assessment Social Histories
        /// </summary>
        public ICollection<NursingAssessmentSocialHistory> NursingAssessmentSocialHistories { get; set; }
        /// <summary>
        /// List of nursing assessment Systems
        /// </summary>
        public ICollection<NursingAssessmentSystem> NursingAssessmentSystems { get; set; }
        /// <summary>
        /// List of nursing assessment Referrals
        /// </summary>
        public ICollection<NursingAssessmentReferral> NursingAssessmentReferrals { get; set; }
    }
}
