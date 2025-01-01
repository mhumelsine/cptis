using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class MedicalEvaluation
    {
        /// <summary>
        /// Unique identifier for the medical evaluation record.
        /// </summary>
        public int MedicalEvaluationId { get; set; }

        /// <summary>
        /// Abuse report number associated with the medical evaluation.
        /// </summary>
        public string AbuseReportNumber { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Identifier of the client associated with the medical evaluation.
        /// </summary>
        public ClientId ClientId { get; set; }

        /// <summary>
        /// Assessment sequence number for the medical evaluation.
        /// </summary>
        public string AssessmentSequenceNumber { get; set; }

        /// <summary>
        /// Registration sequence number for the medical evaluation.
        /// </summary>
        public string RegistrationSequenceNumber { get; set; }

        /// <summary>
        /// Unique number identifying the medical evaluation.
        /// </summary>
        public int? MedicalEvaluationNumber { get; set; }

        /// <summary>
        /// Type of evaluation being performed.
        /// </summary>
        public string EvaluationType { get; set; }

        /// <summary>
        /// Date of the report associated with the evaluation.
        /// </summary>
        public DateTime? ReportDate { get; set; }

        /// <summary>
        /// Identifier for DCFPI (Florida's Department of Children and Families).
        /// </summary>
        public string Dcfpi { get; set; }

        /// <summary>
        /// Law enforcement report number.
        /// </summary>
        public string LawEnforcementNum { get; set; }

        /// <summary>
        /// Coordinator responsible for the case.
        /// </summary>
        public string CaseCoordinator { get; set; }

        /// <summary>
        /// Date of the medical examination.
        /// </summary>
        public DateTime? ExaminationDate { get; set; }

        /// <summary>
        /// Time of the medical examination.
        /// </summary>
        public string ExaminationTime { get; set; }

        /// <summary>
        /// Location code for the examination site.
        /// </summary>
        public string LocationCode { get; set; }

        /// <summary>
        /// Name of the historian providing case information.
        /// </summary>
        public string Historian { get; set; }

        /// <summary>
        /// Indicates if a translation was provided during the examination.
        /// </summary>
        public string TranslationProvided { get; set; }

        /// <summary>
        /// Comments on the chief complaint.
        /// </summary>
        public string ChiefComplaintComment { get; set; }

        /// <summary>
        /// Record creation date.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Last updated date for the record.
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
        /// Detailed history associated with the evaluation.
        /// </summary>
        public string History { get; set; }

        /// <summary>
        /// Review of symptoms provided during the evaluation.
        /// </summary>
        public string ReviewOfSymptoms { get; set; }

        /// <summary>
        /// Physical examination findings.
        /// </summary>
        public string PhysicalExamination { get; set; }

        /// <summary>
        /// Laboratory results.
        /// </summary>
        public string Labs { get; set; }

        /// <summary>
        /// Radiology findings.
        /// </summary>
        public string Radiology { get; set; }

        /// <summary>
        /// Ultrasound findings.
        /// </summary>
        public string Ultrasound { get; set; }

        /// <summary>
        /// Consultations conducted during the evaluation.
        /// </summary>
        public string Consultations { get; set; }

        /// <summary>
        /// Impressions formed during the evaluation.
        /// </summary>
        public string Impressions { get; set; }

        /// <summary>
        /// Indicates if FDLE (Florida Department of Law Enforcement) kit was used.
        /// </summary>
        public string FDLEKit { get; set; }

        /// <summary>
        /// Relationship of the person to the child.
        /// </summary>
        public string RelationshipToChild { get; set; }

        /// <summary>
        /// Navigation property for the related AbuseReport.
        /// </summary>
        public AbuseReport AbuseReport { get; set; }

        /// <summary>
        /// Navigation property for the associated ClientDemographic.
        /// </summary>
        public ClientDemographic ClientDemographic { get; set; }

        /// <summary>
        /// Navigation property for the associated Assessment.
        /// </summary>
        public Assessment Assessment { get; set; }

        /// <summary>
        /// Navigation property for the associated Registration.
        /// </summary>
        public Registration Registration { get; set; }

        /// <summary>
        /// Related MedicalEvaluationAddendums.
        /// </summary>
        public ICollection<MedicalEvaluationAddendum> MedicalEvaluationAddendums { get; set; }

        /// <summary>
        /// Related MedicalEvaluationAllergies.
        /// </summary>
        public ICollection<MedicalEvaluationAllergy> MedicalEvaluationAllergies { get; set; }

        /// <summary>
        /// Related MedicalEvaluationFamilies.
        /// </summary>
        public ICollection<MedicalEvaluationFamily> MedicalEvaluationFamilies { get; set; }

        /// <summary>
        /// Related MedicalEvaluationImmunizations.
        /// </summary>
        public ICollection<MedicalEvaluationImmunization> MedicalEvaluationImmunizations { get; set; }

        /// <summary>
        /// Related MedicalEvaluationMedications.
        /// </summary>
        public ICollection<MedicalEvaluationMedications> MedicalEvaluationMedications { get; set; }
    }
}
