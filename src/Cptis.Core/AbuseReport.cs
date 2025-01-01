using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class AbuseReport
    {
        public class AbuseReport
        {
            /// <summary>
            /// Unique identifier for the abuse report.
            /// </summary>
            public int AbuseReportId { get; set; }

            /// <summary>
            /// Unique number assigned to the abuse report.
            /// </summary>
            public string AbuseReportNumber { get; set; }

            /// <summary>
            /// Sequence number for the abuse report.
            /// </summary>
            public string AbuseReportSequenceNumber { get; set; }

            /// <summary>
            /// Date when the hotline received the abuse report.
            /// </summary>
            public DateTime? HotlineDate { get; set; }

            /// <summary>
            /// Date when the CPT office received the abuse report.
            /// </summary>
            public DateTime? CptReceiveDate { get; set; }

            /// <summary>
            /// Date when the CPT review was conducted.
            /// </summary>
            public DateTime? CptReviewDate { get; set; }

            /// <summary>
            /// Date when exceptions for the abuse report were noted.
            /// </summary>
            public DateTime? CptException { get; set; }

            /// <summary>
            /// Reason for any noted exceptions in the abuse report.
            /// </summary>
            public string CptExceptionReason { get; set; }

            /// <summary>
            /// CPT office handling the abuse report.
            /// </summary>
            public string CptOffice { get; set; }

            /// <summary>
            /// Criteria for mandatory referral based on the report.
            /// </summary>
            public string MandatoryReferralCriteria { get; set; }

            /// <summary>
            /// Indicates if a medical review was required.
            /// </summary>
            public string MedicalReviewRequired { get; set; }

            /// <summary>
            /// Date when the medical review was conducted.
            /// </summary>
            public DateTime? MedicalReviewDate { get; set; }

            /// <summary>
            /// Date when DCF was notified about the abuse report.
            /// </summary>
            public DateTime? DcfNotifyDate { get; set; }

            /// <summary>
            /// District or area unit where the abuse report originated.
            /// </summary>
            public string DistrictAreaUnit { get; set; }

            /// <summary>
            /// County associated with the abuse report.
            /// </summary>
            public string ArCounty { get; set; }

            /// <summary>
            /// Additional comments regarding the abuse report.
            /// </summary>
            public string Comments { get; set; }

            /// <summary>
            /// First name of the user who created or updated the report.
            /// </summary>
            public string UserFirstName { get; set; }

            /// <summary>
            /// Last name of the user who created or updated the report.
            /// </summary>
            public string UserLastName { get; set; }

            /// <summary>
            /// Indicates if the abuse report is linked to cross-team efforts.
            /// </summary>
            public string CrossTeam { get; set; }

            /// <summary>
            /// Date when the referral was declined.
            /// </summary>
            public DateTime? DateReferralDeclined { get; set; }

            /// <summary>
            /// Reason provided for declining the referral.
            /// </summary>
            public string ReasonReferralDeclined { get; set; }

            /// <summary>
            /// Indicates if the case qualifies for VOCA funding.
            /// </summary>
            public string IsVocaCase { get; set; }

            /// <summary>
            /// Indicates if the abuse report is linked to other cases.
            /// </summary>
            public string Linked { get; set; }

            /// <summary>
            /// Reason for any exceptions in linking the abuse report.
            /// </summary>
            public string ExceptReason { get; set; }

            /// <summary>
            /// Indicates if the abuse report is linked to an intake.
            /// </summary>
            public string LinkedToIntake { get; set; }

            /// <summary>
            /// Indicates if the abuse report is a restricted case.
            /// </summary>
            public string IsRestrictedCase { get; set; }

            /// <summary>
            /// Indicates if the abuse report includes an attestation.
            /// </summary>
            public string HasAttestation { get; set; }

            /// <summary>
            /// Date when the abuse report was prepared.
            /// </summary>
            public DateTime? PreparedDate { get; set; }

            /// <summary>
            /// Name of the person who prepared the abuse report.
            /// </summary>
            public string PreparedBy { get; set; }

            /// <summary>
            /// Medical office associated with the abuse report.
            /// </summary>
            public string CptMedicalOffice { get; set; }

            /// <summary>
            /// Date when DCF was notified by the CPT.
            /// </summary>
            public DateTime? DcfNotifiedDate { get; set; }

            /// <summary>
            /// Date when the abuse report was created.
            /// </summary>
            public DateTime? CreateDate { get; set; }

            /// <summary>
            /// Name of the person who created the abuse report.
            /// </summary>
            public string CreateBy { get; set; }

            /// <summary>
            /// Date when the abuse report was last updated.
            /// </summary>
            public DateTime? UpdateDate { get; set; }

            /// <summary>
            /// Name of the person who last updated the abuse report.
            /// </summary>
            public string UpdatedBy { get; set; }

            /// <summary>
            /// Indicates whether the abuse report is marked as deleted.
            /// </summary>
            public bool IsDeleted { get; set; }
            /// <summary>
            /// Audit details about when the client was created and modified
            /// </summary>
            public Audit Audit { get; set; } = new();

            // Navigation properties
            /// <summary>
            /// List of abuse report links associated with this report.
            /// </summary>
            public ICollection<AbuseReportLink> AbuseReportLinks { get; set; }
        }
        
        
    }
}
