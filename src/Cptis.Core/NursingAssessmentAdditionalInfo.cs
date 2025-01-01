using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class NursingAssessmentAdditionalInfo
    {
        /// <summary>
        /// Unique identifier for the additional information record.
        /// </summary>
        public int NursingAssessmentAddtionalInfoId { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Reference to the associated Nursing Assessment.
        /// </summary>
        public int NursingAssessmentId { get; set; }

        /// <summary>
        /// Status of the individual's feeding habits.
        /// </summary>
        public string FeedingStatus { get; set; }

        /// <summary>
        /// Additional comments about the individual's feeding habits.
        /// </summary>
        public string FeedingComment { get; set; }

        /// <summary>
        /// Status of the individual's bathing habits.
        /// </summary>
        public string BathingStatus { get; set; }

        /// <summary>
        /// Additional comments about the individual's bathing habits.
        /// </summary>
        public string BathingComment { get; set; }

        /// <summary>
        /// Status of the individual's toileting habits.
        /// </summary>
        public string ToiletingStatus { get; set; }

        /// <summary>
        /// Additional comments about the individual's toileting habits.
        /// </summary>
        public string ToiletingComment { get; set; }

        /// <summary>
        /// Status of the individual's ability to dress themselves.
        /// </summary>
        public string DressingStatus { get; set; }

        /// <summary>
        /// Additional comments about the individual's ability to dress themselves.
        /// </summary>
        public string DressingComment { get; set; }

        /// <summary>
        /// Status of the individual's mobility.
        /// </summary>
        public string MobilityStatus { get; set; }

        /// <summary>
        /// Additional comments about the individual's mobility.
        /// </summary>
        public string MobilityComment { get; set; }

        /// <summary>
        /// Status of the individual's play activities.
        /// </summary>
        public string PlayStatus { get; set; }

        /// <summary>
        /// Additional comments about the individual's play activities.
        /// </summary>
        public string PlayComment { get; set; }

        /// <summary>
        /// Status of the individual's sleep habits.
        /// </summary>
        public string SleepHabitStatus { get; set; }

        /// <summary>
        /// Additional comments about the individual's sleep habits.
        /// </summary>
        public string SleepHabitComment { get; set; }

        /// <summary>
        /// Status of the individual's communication abilities.
        /// </summary>
        public string CommunicationStatus { get; set; }

        /// <summary>
        /// Additional comments about the individual's communication abilities.
        /// </summary>
        public string CommunicationComment { get; set; }

        /// <summary>
        /// Status of the individual's cognitive abilities.
        /// </summary>
        public string CognitiveStatus { get; set; }

        /// <summary>
        /// Additional comments about the individual's cognitive abilities.
        /// </summary>
        public string CognitiveComment { get; set; }

        /// <summary>
        /// Status of the individual's social and emotional well-being.
        /// </summary>
        public string SocialEmotionalStatus { get; set; }

        /// <summary>
        /// Additional comments about the individual's social and emotional well-being.
        /// </summary>
        public string SocialEmotionalComment { get; set; }

        /// <summary>
        /// Status of the individual's developmental progress.
        /// </summary>
        public string DevelopmentalStatus { get; set; }

        /// <summary>
        /// Additional comments about the individual's developmental progress.
        /// </summary>
        public string DevelopmentalComment { get; set; }

        /// <summary>
        /// Indicates whether the individual chokes on food.
        /// </summary>
        public string ChokeOnFoodStatus { get; set; }

        /// <summary>
        /// Additional comments about choking on food.
        /// </summary>
        public string ChokeOnFoodComment { get; set; }

        /// <summary>
        /// Indicates whether the individual is a picky eater.
        /// </summary>
        public string PickyEaterStatus { get; set; }

        /// <summary>
        /// Additional comments about picky eating habits.
        /// </summary>
        public string PickyEaterComment { get; set; }

        /// <summary>
        /// Indicates whether the individual requires a special diet.
        /// </summary>
        public string SpecialDietStatus { get; set; }

        /// <summary>
        /// Additional comments about special dietary needs.
        /// </summary>
        public string SpecialDietComment { get; set; }

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
