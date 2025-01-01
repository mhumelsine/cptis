using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents the SATP intake information.
    /// </summary>
    public class SatpIntake
    {
        /// <summary>
        /// Unique identifier for the SATP intake record.
        /// </summary>
        public int SatpIntakeId { get; set; }

        /// <summary>
        /// Identifier for the related client demographic.
        /// </summary>
        public int ClientDemographicId { get; set; }

        /// <summary>
        /// Case number associated with the SATP intake.
        /// </summary>
        public string CaseNumber { get; set; }

        /// <summary>
        /// Law enforcement report number associated with the case.
        /// </summary>
        public string LawEnforcementReportNumber { get; set; }

        /// <summary>
        /// Office code associated with the SATP intake.
        /// </summary>
        public string OfficeCode { get; set; }

        /// <summary>
        /// Code indicating the reports obtained.
        /// </summary>
        public string ReportsObtainedCode { get; set; }

        /// <summary>
        /// Date when reports were obtained.
        /// </summary>
        public DateTime? DateObtained { get; set; }

        /// <summary>
        /// Code for the provider related to the SATP intake.
        /// </summary>
        public string ProviderCode { get; set; }

        /// <summary>
        /// County code where the intake is associated.
        /// </summary>
        public string CountyCode { get; set; }

        /// <summary>
        /// Date of referral.
        /// </summary>
        public DateTime? ReferralDate { get; set; }

        /// <summary>
        /// Code for the referral source.
        /// </summary>
        public string ReferralSourceCode { get; set; }

        /// <summary>
        /// Code for the type of abuse associated with the intake.
        /// </summary>
        public string AbuseTypeCode { get; set; }

        /// <summary>
        /// Code for the client type.
        /// </summary>
        public string ClientTypeCode { get; set; }

        /// <summary>
        /// Code for the victim-perpetrator relationship.
        /// </summary>
        public string VictimPerpRelationCode { get; set; }

        /// <summary>
        /// Date of termination of services.
        /// </summary>
        public DateTime? TerminationDate { get; set; }

        /// <summary>
        /// Code for the reason of termination.
        /// </summary>
        public string TerminationReasonCode { get; set; }

        /// <summary>
        /// VOCA ID associated with the intake.
        /// </summary>
        public string IdVoca { get; set; }

        /// <summary>
        /// Status of the victim in the intake.
        /// </summary>
        public string VictimStatus { get; set; }

        /// <summary>
        /// Identifier for the summary comment.
        /// </summary>
        public int? SummaryCommentId { get; set; }

        /// <summary>
        /// Identifier for other comments related to the intake.
        /// </summary>
        public int? OtherCommentId { get; set; }

        /// <summary>
        /// Identifier for other referral source comments.
        /// </summary>
        public int? OtherReferralSourceCommentId { get; set; }

        /// <summary>
        /// Date of initial services contact.
        /// </summary>
        public DateTime? InitialServicesContactDate { get; set; }

        /// <summary>
        /// Date when the intake was created.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Date when the intake was last updated.
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// First name of the user who created the intake.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Last name of the user who created the intake.
        /// </summary>
        public string UserLastName { get; set; }

        /// <summary>
        /// Date of the intake.
        /// </summary>
        public DateTime? IntakeDate { get; set; }

        /// <summary>
        /// Additional comments related to the intake.
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Indicates whether the intake is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
