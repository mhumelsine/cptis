using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class NursingAssessmentSocialHistory
    {
        /// <summary>
        /// Unique identifier for the social history record.
        /// </summary>
        public int NursingAssessmentSocialHistoryId { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Reference to the associated Nursing Assessment.
        /// </summary>
        public int NursingAssessmentId { get; set; }

        /// <summary>
        /// Information about who the child lives with.
        /// </summary>
        public string ChildLivesWith { get; set; }

        /// <summary>
        /// Status of significant events in the child's life.
        /// </summary>
        public string EventsStatus { get; set; }

        /// <summary>
        /// Details about significant events in the child's life.
        /// </summary>
        public string Events { get; set; }

        /// <summary>
        /// Status of behavioral concerns.
        /// </summary>
        public string BehavioralStatus { get; set; }

        /// <summary>
        /// Details about behavioral concerns.
        /// </summary>
        public string Behavioral { get; set; }

        /// <summary>
        /// Status of caregiving arrangements.
        /// </summary>
        public string CaringForStatus { get; set; }

        /// <summary>
        /// Details about caregiving arrangements.
        /// </summary>
        public string CaringFor { get; set; }

        /// <summary>
        /// Status of family strengths.
        /// </summary>
        public string FamilyStrengthsStatus { get; set; }

        /// <summary>
        /// Details about family strengths.
        /// </summary>
        public string FamilyStrengths { get; set; }

        /// <summary>
        /// Status of family support systems.
        /// </summary>
        public string FamilySupportStatus { get; set; }

        /// <summary>
        /// Details about family support systems.
        /// </summary>
        public string FamilySupport { get; set; }

        /// <summary>
        /// Status of family employment.
        /// </summary>
        public string FamilyEmploymentStatus { get; set; }

        /// <summary>
        /// Details about family employment.
        /// </summary>
        public string FamilyEmployment { get; set; }

        /// <summary>
        /// Status of the home environment.
        /// </summary>
        public string HomeEnvironmentStatus { get; set; }

        /// <summary>
        /// Details about the home environment.
        /// </summary>
        public string HomeEnvironment { get; set; }

        /// <summary>
        /// Status of transportation availability.
        /// </summary>
        public string TransportationStatus { get; set; }

        /// <summary>
        /// Details about transportation availability.
        /// </summary>
        public string Transportation { get; set; }

        /// <summary>
        /// Status of school and learning concerns.
        /// </summary>
        public string SchoolAndLearningStatus { get; set; }

        /// <summary>
        /// Details about school and learning concerns.
        /// </summary>
        public string SchoolAndLearning { get; set; }

        /// <summary>
        /// Status of cultural considerations.
        /// </summary>
        public string CulturalStatus { get; set; }

        /// <summary>
        /// Details about cultural considerations.
        /// </summary>
        public string Cultural { get; set; }

        /// <summary>
        /// Status of substance abuse concerns.
        /// </summary>
        public string SubstanceAbuseStatus { get; set; }

        /// <summary>
        /// Details about substance abuse concerns.
        /// </summary>
        public string SubstanceAbuse { get; set; }

        /// <summary>
        /// Status of community service involvement.
        /// </summary>
        public string CommunityServiceStatus { get; set; }

        /// <summary>
        /// Details about community service involvement.
        /// </summary>
        public string CommunityService { get; set; }

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
