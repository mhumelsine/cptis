using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class NursingAssessmentRiskFactor
    {
        /// <summary>
        /// Unique identifier for the risk factor record.
        /// </summary>
        public int NursingAssessmentRiskFactorId { get; set; }

        /// <summary>
        /// Reference to the associated Nursing Assessment.
        /// </summary>
        public int NursingAssessmentId { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Indicates if the child is under 2 years old.
        /// </summary>
        public bool ChildUnder2 { get; set; }

        /// <summary>
        /// Indicates if the child has special needs.
        /// </summary>
        public bool SpecialNeeds { get; set; }

        /// <summary>
        /// Indicates if the caregiver has a history of arrest.
        /// </summary>
        public bool CareGiverArrestHx { get; set; }

        /// <summary>
        /// Indicates if the child has expressed fear.
        /// </summary>
        public bool ChildStatesFear { get; set; }

        /// <summary>
        /// Indicates if there are prior reports to DCF.
        /// </summary>
        public bool PriorDcfReports { get; set; }

        /// <summary>
        /// Indicates if there is a history of violence in the family.
        /// </summary>
        public bool HxOfViolence { get; set; }

        /// <summary>
        /// Indicates the severity of the incident.
        /// </summary>
        public bool SeverityOfIncident { get; set; }

        /// <summary>
        /// Indicates if the parent has a history of abuse.
        /// </summary>
        public bool ParentHxAbuse { get; set; }

        /// <summary>
        /// Indicates if there are prior CPT referrals.
        /// </summary>
        public bool PriorCptReferrals { get; set; }

        /// <summary>
        /// Indicates if the child is too young to provide a statement.
        /// </summary>
        public bool ChildToYoung { get; set; }

        /// <summary>
        /// Indicates if the family is socially isolated.
        /// </summary>
        public bool Isolation { get; set; }

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
