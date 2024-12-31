using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class Intake
    {
        /// <summary>
        /// The system assigned unique identifier for the intake
        /// </summary>
        public int IntakeId { get; set; }
        /// <summary>
        /// FK reference to corresponding Abuse Report
        /// </summary>
        public int AbuseReportId { get; set; }
        /// <summary>
        /// DCF Assigned abuse report number
        /// </summary>
        public string AbuseReportNumber { get; set; }
        /// <summary>
        /// Identifier/Indicator of multiple abuse reports with the same number
        /// </summary>
        public string AbuseReportSequenceNumber { get; set; }
        /// <summary>
        /// The unique client Identifier for the system
        /// </summary>
        public ClientId ClientId { get; set; }
        /// <summary>
        /// The CPT Office designation where the Intake occurrs
        /// </summary>
        public string CptOffice { get; set; }
        /// <summary>
        /// The county code of the corresponding Florida county where intake occurs
        /// </summary>
        public string County { get; set; }
        /// <summary>
        /// Name of CPI handling the case
        /// </summary>
        public string CpiName { get; set; }
        /// <summary>
        /// Indicates if a case is mandatory referral
        /// </summary>
        public string MandatoryReferral { get; set; }
        /// <summary>
        /// Indicates if a medical review is required
        /// </summary>
        public string MedicalReviewRequired { get; set; }
        /// <summary>
        /// The case or intake coordinator completing the intake.
        /// </summary>
        public string CoordinatorCompletingIntake { get; set; }
        /// <summary>
        /// Law Enforcement Report Number corresponding to the Case
        /// </summary>
        public string LawEnforcementReportNumber { get; set; }
        /// <summary>
        /// Indicator as to who referred the client
        /// </summary>
        public string ReferralSource { get; set; }
        /// <summary>
        /// Indicator of Substance Abuse in a case
        /// </summary>
        public string SubstanceAbuse { get; set; }
        /// <summary>
        /// Indicator of Domestic Violence in a case
        /// </summary>
        public string DomesticViolence { get; set; }
        /// <summary>
        /// Does pepetrator in case have a criminal history
        /// </summary>
        public string CriminalHistory { get; set; }
        /// <summary>
        /// Are there mental health issues involved in the case
        /// </summary>
        public string MentalHealth { get; set; }
        /// <summary>
        /// is the client a child 6 years old or younger
        /// </summary>
        public string ChildZeroToSix { get; set; }
        /// <summary>
        /// Is there a medical evaluation required for this case
        /// </summary>
        public string MedicalEvaluationRequired { get; set; }
        /// <summary>
        /// Indicates why a medical evaluation is not required/needed
        /// </summary>
        public string MedicalEvaluationException { get; set; }
        /// <summary>
        /// indicator of physician concurring with medical evaluation
        /// </summary>
        public string PhysicianConcur { get; set; }
        /// <summary>
        /// Indicator of a medical evaluation being Needed
        /// </summary>
        public string MedicalEvaluationNeeded { get; set; }
        /// <summary>
        /// Is this a cross team case
        /// </summary>
        public string CrossTeam { get; set; }
        /// <summary>
        /// What cross team office is assisting in this case
        /// </summary>
        public string SecondCptOffice { get; set; }
        /// <summary>
        /// What service type is associated with the intake.
        /// </summary>
        public string ServiceTypeCode { get; set; }
        /// <summary>
        /// Code indicating type of medical exception associated with intake
        /// </summary>
        public string MedicalExceptionCode { get; set; }
        /// <summary>
        /// The code selected indicating closure reason of intake
        /// </summary>
        public string ClosureCode { get; set; }
        /// <summary>
        /// Comments from relevant personnel regarding any medical evaluation associated with the intake
        /// </summary>
        public string MedicalEvaluationComments { get; set; }
        /// <summary>
        /// Any prior events that are relevant to the case
        /// </summary>
        public string Priors { get; set; }
        /// <summary>
        /// Code indicating the reason for the client's referral to CPT
        /// </summary>
        public string ReasonForReferral { get; set; }
        /// <summary>
        /// Decisions made regarding the status of a referral
        /// </summary>
        public string ReferralDecision { get; set; }
        /// <summary>
        /// Details regarding the medical exception
        /// </summary>
        public string MedicalExceptionSpecify { get; set; }
        /// <summary>
        /// Date client referred to CPT
        /// </summary>
        public string CptReferralDate { get; set; }
        /// <summary>
        /// Date medical review of intake ocurred
        /// </summary>
        public string MedicalReviewDate { get; set; }
        /// <summary>
        /// Date CPT Reviewed intake
        /// </summary>
        public string CptReviewDate { get; set; }
        /// <summary>
        /// Date services related to intake scheduled
        /// </summary>
        public DateTime? ScheduleDate { get; set; }
        /// <summary>
        /// Date intake closed
        /// </summary>
        public string ClosureDate { get; set; }
        /// <summary>
        /// Date record created
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// Date Record updated
        /// </summary>
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// First name of last user to touch the record
        /// </summary>
        public string UserFirstName { get; set; }
        /// <summary>
        /// Last name of last user to touch the record
        /// </summary>
        public string UserLastName { get; set; }
        /// <summary>
        /// Indicator of funding source of case
        /// </summary>
        public string IsVoca { get; set; }
        /// <summary>
        /// Indicates whether or not record deleted.
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        // Navigation Properties
        public AbuseReport AbuseReport { get; set; }
        public ICollection<IntakeService> IntakeServices { get; set; }
        public ICollection<IntakeAddendum> IntakeAddenda { get; set; }
        public ICollection<IntakeFamily> IntakeFamilies { get; set; }
        public ICollection<IntakeMaltreatment> IntakeMaltreatments { get; set; }
        public ICollection<ClientCase> ClientCases { get; set; }
    }

}
