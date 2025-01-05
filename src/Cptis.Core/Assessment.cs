using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class Assessment
    {
        /// <summary>
        /// Unique identifier for the assessment.
        /// </summary>
        public int AssessmentId { get; set; }

        /// <summary>
        /// Client's unique identifier.
        /// </summary>
        public ClientId ClientId { get; set; }

        /// <summary>
        /// Foreign key referencing the client demographic.
        /// </summary>
        public int? ClientDemographicId { get; set; }

        /// <summary>
        /// Foreign key referencing the registration associated with this assessment.
        /// </summary>
        public int? RegistrationId { get; set; }

        /// <summary>
        /// Foreign key referencing the related abuse report.
        /// </summary>
        public int? AbuseReportId { get; set; }

        /// <summary>
        /// Unique number for the abuse report.
        /// </summary>
        public string AbuseReportNumber { get; set; }

        /// <summary>
        /// Code identifying the provider responsible for the assessment.
        /// </summary>
        public string ProviderCode { get; set; }

        /// <summary>
        /// Type of service provided during the assessment.
        /// </summary>
        public string ServiceType { get; set; }

        /// <summary>
        /// Date the service was provided.
        /// </summary>
        public DateTime? ServiceDate { get; set; }

        /// <summary>
        /// Location where the assessment took place.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Additional comments or details about the assessment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Office where the assessment was conducted.
        /// </summary>
        public string CptOffice { get; set; }

        /// <summary>
        /// Indicates if the assessment was conducted via telemedicine.
        /// </summary>
        public string Telemedicine { get; set; }

        /// <summary>
        /// Remote site location for the assessment.
        /// </summary>
        public string RemoteSite { get; set; }

        /// <summary>
        /// Hub site location for the assessment.
        /// </summary>
        public string HubSite { get; set; }

        /// <summary>
        /// Details about the physical medical exam.
        /// </summary>
        public string MedicalExamPhysical { get; set; }

        /// <summary>
        /// Details about neglect identified during the medical exam.
        /// </summary>
        public string MedicalExamNeglect { get; set; }

        /// <summary>
        /// Details about sexual abuse identified during the medical exam.
        /// </summary>
        public string MedicalExamSexual { get; set; }

        /// <summary>
        /// Type of provider performing the assessment.
        /// </summary>
        public string ProviderType { get; set; }

        /// <summary>
        /// County where the assessment occurred.
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Type of court activity associated with the assessment.
        /// </summary>
        public string CourtActivityType { get; set; }

        /// <summary>
        /// Wait time before the assessment was conducted.
        /// </summary>
        public string WaitTime { get; set; }

        /// <summary>
        /// Date when the assessment record was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Date when the assessment record was last updated.
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
        /// Date the Department of Children and Families (DCF) was notified.
        /// </summary>
        public DateTime? DateToDCF { get; set; }

        /// <summary>
        /// Type of assessment conducted.
        /// </summary>
        public string AssessmentType { get; set; }

        /// <summary>
        /// Reason provided to DCF.
        /// </summary>
        public string DCFReason { get; set; }

        /// <summary>
        /// Positive findings identified during the assessment.
        /// </summary>
        public string PositiveFinding { get; set; }

        /// <summary>
        /// Date when verbal notification of the findings was made.
        /// </summary>
        public DateTime? VerbalNotification { get; set; }

        /// <summary>
        /// Date when positive findings were identified.
        /// </summary>
        public DateTime? PositiveFindingDate { get; set; }

        /// <summary>
        /// Source of the referral for the assessment.
        /// </summary>
        public string ReferralSource { get; set; }

        /// <summary>
        /// Indicates whether handbook requirements were met.
        /// </summary>
        public string HandbookRequirementNotMet { get; set; }

        /// <summary>
        /// Indicates whether a remote provider was involved.
        /// </summary>
        public string RemoteProvider { get; set; }

        /// <summary>
        /// Funding source from the Child Advocacy Center (CAC).
        /// </summary>
        public string CACFunding { get; set; }

        /// <summary>
        /// Other sources of funding for the assessment.
        /// </summary>
        public string OtherFunding { get; set; }

        /// <summary>
        /// Indicates whether the assessment involved medically complex cases.
        /// </summary>
        public string MedicallyComplex { get; set; }

        /// <summary>
        /// Indicates whether the provider had expertise in the subject matter.
        /// </summary>
        public string PhysicianWithExpertise { get; set; }

        /// <summary>
        /// Indicates whether the provider was part of the CMS network.
        /// </summary>
        public string CMSNetworkPhysician { get; set; }

        /// <summary>
        /// Details about any other issues with the MPC process.
        /// </summary>
        public string MPCOther { get; set; }

        /// <summary>
        /// Indicates if the provider was unable to comply with requirements.
        /// </summary>
        public string UnableToComply { get; set; }

        /// <summary>
        /// Description of why compliance was not possible.
        /// </summary>
        public string UnableToComplyDescription { get; set; }

        /// <summary>
        /// Details about obesity findings.
        /// </summary>
        public string Obesity { get; set; }

        /// <summary>
        /// Indicates if nutritional counseling was provided.
        /// </summary>
        public string NutritionalCounseling { get; set; }

        /// <summary>
        /// Indicates whether DCF was notified about findings.
        /// </summary>
        public string DCFNotified { get; set; }

        /// <summary>
        /// Additional information about obesity findings.
        /// </summary>
        public string ObesityDescribe { get; set; }

        /// <summary>
        /// Description of other MPC-related findings.
        /// </summary>
        public string MPCOtherDescribe { get; set; }

        /// <summary>
        /// Indicates if medical neglect was substantiated.
        /// </summary>
        public string MedicalNeglectSubstantiated { get; set; }

        /// <summary>
        /// Date when DCF was notified of medical neglect findings.
        /// </summary>
        public DateTime? MedicalNeglectDateDCFNotified { get; set; }

        /// <summary>
        /// Indicates whether the assessment was conducted on-call.
        /// </summary>
        public string OnCall { get; set; }

        /// <summary>
        /// Date when data entry for the assessment was completed.
        /// </summary>
        public DateTime? DataEntryDate { get; set; }

        /// <summary>
        /// Indicates findings related to Munchausen Syndrome.
        /// </summary>
        public string MunchausenSyndrome { get; set; }

        /// <summary>
        /// Indicates if the case qualifies for VOCA funding.
        /// </summary>
        public string IsVoca { get; set; }

        /// <summary>
        /// Unique sequence number for the assessment.
        /// </summary>
        public string AssessmentSequenceNumber { get; set; }

        /// <summary>
        /// Unique sequence number for the registration.
        /// </summary>
        public string RegistrationSequenceNumber { get; set; }

        /// <summary>
        /// Indicates whether the record is marked as deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        // Navigation properties
        /// <summary>
        /// Related client demographic information.
        /// </summary>
        public ClientDemographic ClientDemographic { get; set; }

        /// <summary>
        /// Associated registration details.
        /// </summary>
        public Registration Registration { get; set; }

        /// <summary>
        /// Related abuse report details.
        /// </summary>
        public AbuseReport AbuseReport { get; set; }

        /// <summary>
        /// Associated provider details.
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// List of assessment documents
        /// </summary>
        public ICollection<AssessmentDocument> AssessmentDocuments { get; set; }

        /// <summary>
        /// List of assessment observers
        /// </summary>
        public ICollection<AssessmentObserver> AssessmentObservers { get; set; }

        /// <summary>
        /// List of STDs 
        /// </summary>
        public ICollection<AssessmentSTD> AssessmentSTDs { get; set; }
    }

}
