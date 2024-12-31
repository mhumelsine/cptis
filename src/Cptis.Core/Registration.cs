using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class Registration
    {
        /// <summary>
        /// The system assigned unique identifier for the Registration
        /// </summary>
        public int RegistrationId { get; set; }
        /// <summary>
        /// System created number for the registration
        /// </summary>
        public string RegistrationSequenceNum { get; set; }
        /// <summary>
        /// FK to intake corresponding to registration
        /// </summary>
        public int IntakeId { get; set; }
        /// <summary>
        /// FK to abuse report corresponding to Registration
        /// </summary>
        public int AbuseReportId { get; set; }
        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();
        /// <summary>
        /// Case number created by DCF for registration
        /// </summary>
        public string CaseNumber { get; set; }
        /// <summary>
        /// Initial Date of Registratoin
        /// </summary>
        public DateTime InitialDate { get; set; }
        /// <summary>
        /// Closure Date of Registration
        /// </summary>
        public DateTime TerminateDate { get; set; }
        /// <summary>
        /// The CPT office in which registration occurs
        /// </summary>
        public string CptOffice { get; set; }
        /// <summary>
        /// Florida State County where registration takes place
        /// </summary>
        public string County { get; set; }
        /// <summary>
        /// A code representing a link to the provider record for the case coordinator
        /// </summary>
        public string CoordinatorCode { get; set; }
        /// <summary>
        /// case coordinator's name
        /// </summary>
        public string CaseCoordinator { get; set; }
        /// <summary>
        /// code representing the referral source for the case
        /// </summary>
        public string ReferralSource { get; set; }
        /// <summary>
        /// General comment about the registration
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Code representing an overall assessment of the case.
        /// </summary>
        public string OverallCptAssessment { get; set; }
        /// <summary>
        /// Created Date for the record
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// Update date for the record
        /// </summary>
        public DateTime UpdateDate { get; set; }
        /// <summary>
        /// First name of the last user to "touch" the registration
        /// </summary>
        public string UserFirstName { get; set; }
        /// <summary>
        /// Last name of the last user to "touch" the registration
        /// </summary>
        public string UserLastName { get; set; }
        /// <summary>
        /// Name of CPI for Case
        /// </summary>
        public string CPIName { get; set; }
        /// <summary>
        /// Additional comments about registration
        /// </summary>
        public string Comments { get; set; }
        /// <summary>
        /// indicator of whether or not Registration is crossteam
        /// </summary>
        public string IsCrossTeam { get; set; }
        /// <summary>
        /// CPT Office code for the cross team office
        /// </summary>
        public string CrossTeamOffice { get; set; }
        /// <summary>
        /// Case coordinator in cross team office handling case
        /// </summary>
        public string CrossTeamCoordinatorCode { get; set; }
        /// <summary>
        /// Date ICS Notified
        /// </summary>
        public DateTime DateIcsSent { get; set; }
        /// <summary>
        /// Date FCS Notified
        /// </summary>
        public DateTime DateFcsSent { get; set; }
        /// <summary>
        /// Additional referral source for registration
        /// </summary>
        public string SecondReferralSource { get; set; }
        /// <summary>
        /// Alternate Abuse Report Numbers
        /// </summary>
        public string AlternateAbuseReportNums { get; set; }
        /// <summary>
        /// indicator of early steps referral
        /// </summary>
        public string EarlyStepsReferred { get; set; }
        /// <summary>
        /// Indicator of early steps screened
        /// </summary>
        public string EarlyStepsScreened { get; set; }
        /// <summary>
        /// indicator if client is currently enrolled in early steps
        /// </summary>
        public string EarlyStepsCurrentlyEnrolled { get; set; }
        /// <summary>
        /// Does case meet referral criteria for early steps
        /// </summary>
        public string EarlyStepsMeetsReferral { get; set; }
        /// <summary>
        /// Is case referred to SATP
        /// </summary>
        public string ReferredToSATP { get; set; }
        /// <summary>
        /// Date client screened for early steps
        /// </summary>
        public DateTime EarlyStepsScreenDate { get; set; }
        /// <summary>
        /// Date Client referred to early steps
        /// </summary>
        public DateTime EarlyStepsReferredDate { get; set; }
        /// <summary>
        /// indicator of early steps developmental delay
        /// </summary>
        public string EarlyStepsDevelopmentalDelayIdentified { get; set; }
        /// <summary>
        /// indicator of whether or not client referred to other agency
        /// </summary>
        public string EarlyStepsReferredOtherAgency { get; set; }
        /// <summary>
        /// Date client referred to other agency
        /// </summary>
        public DateTime EarlyStepsReferredOtherAgencyDate { get; set; }
        /// <summary>
        /// name of other agency client referred to
        /// </summary>
        public string EarlyStepsReferredOtherAgencyName { get; set; }
        /// <summary>
        /// Does client have Neonatal Abstinence Syndrome
        /// </summary>
        public string NASDiagnosis { get; set; }
        /// <summary>
        /// Date client referred to other therapy service
        /// </summary>
        public DateTime ReferredToOtherTherapyServiceDate { get; set; }
        /// <summary>
        /// Reason client referred to other SATP agency
        /// </summary>
        public string ReferredToSATPOtherAgencyReason { get; set; }
        /// <summary>
        /// Name of other SATP agency
        /// </summary>
        public string ReferredToSATPOtherAgencyName { get; set; }
        /// <summary>
        /// Name of early intervention agency
        /// </summary>
        public string EarlyInterventionAgencyName { get; set; }
        /// <summary>
        /// indicator of early intervention verified
        /// </summary>
        public string EarlyInterventionVerified { get; set; }
        /// <summary>
        /// indicator of early intervention declared.
        /// </summary>
        public string EarlyInterventionDeclared { get; set; }
        /// <summary>
        /// Indicator of suspicion of Neonatal Abstinence Syndrome
        /// </summary>
        public string NASSuspected { get; set; }
        /// <summary>
        /// Indicator of Neonatal Abstinence Syndrome verified
        /// </summary>
        public string NASConfirmed { get; set; }
        /// <summary>
        /// Inticator of source of suspected confrimation
        /// </summary>
        public string SourceOfConfirmationSuspected { get; set; }
        /// <summary>
        /// indicator of source of confirmation confirmed
        /// </summary>
        public string SourceOfConfirmationConfirmed { get; set; }
        /// <summary>
        /// Reason referral not submitted for Early Steps
        /// </summary>
        public string ReferralNotSubmittedReasonText { get; set; }
        /// <summary>
        /// Early Steps screening verified
        /// </summary>
        public string ScreenedVerified { get; set; }
        /// <summary>
        /// Early steps screening declared necessary
        /// </summary>
        public string ScreenedDeclared { get; set; }
        /// <summary>
        /// Agency provider for screening
        /// </summary>
        public string ScreenedAgencyProvider { get; set; }
        /// <summary>
        /// code value for result of screening
        /// </summary>
        public string ScreenedDropDown { get; set; }
        /// <summary>
        /// Reason client not screened for early steps
        /// </summary>
        public string ReasonNotScreened { get; set; }
        /// <summary>
        /// Results of not being screened 
        /// </summary>
        public string NotScreenedDropDown { get; set; }
        /// <summary>
        /// indicator of on call case
        /// </summary>
        public string OnCallCase { get; set; }
        /// <summary>
        /// Date client referred to SATP
        /// </summary>
        public DateTime ReferredToSATPDOHDate { get; set; }
        /// <summary>
        /// Location of SATP client referred to
        /// </summary>
        public string ReferredToSATPLocation { get; set; }
        /// <summary>
        /// user who created registration
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// user who updated registration
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// indicator of whether or not record deleted
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// corresponding intake for registration
        /// </summary>
        public Intake Intake { get; set; }
        /// <summary>
        /// corresponding abuse report for registration
        /// </summary>
        public AbuseReport AbuseReport { get; set; }
        /// <summary>
        /// List of family members related to clients in a registration
        /// </summary>
        public ICollection<RegistrationFamily> Families { get; set; }
        /// <summary>
        /// Registrations linked to this registration
        /// </summary>
        public ICollection<RegistrationLink> RegistrationLinks { get; set; }
        /// <summary>
        /// List of alleged and assessed maltreatments for registrations
        /// </summary>
        public ICollection<RegistrationMaltreatment> RegistrationMaltreatments { get; set; }
    }
}
