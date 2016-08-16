

namespace XFramework.Models
{

    // WFActivities
    
    public class WfActivity
    {

        ///<summary>
        /// ID (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// ActivityName (length: 50)
        ///</summary>
        public string ActivityName { get; set; }

        ///<summary>
        /// ActivityType (length: 50)
        ///</summary>
        public string ActivityType { get; set; }

        ///<summary>
        /// DurationType (length: 50)
        ///</summary>
        public string DurationType { get; set; }

        ///<summary>
        /// Duration
        ///</summary>
        public decimal Duration { get; set; }

        ///<summary>
        /// Description
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<WfFlowStep> WfFlowSteps { get; set; } // WFFlowSteps.FK_WFFlowSteps_WFActivity
        public virtual System.Collections.Generic.ICollection<WfInstanceFlowStep> WfInstanceFlowSteps { get; set; } // WFInstanceFlowSteps.FK_WFInstanceFlowSteps_WFActivity

        public WfActivity()
        {
            WfFlowSteps = new System.Collections.Generic.List<WfFlowStep>();
            WfInstanceFlowSteps = new System.Collections.Generic.List<WfInstanceFlowStep>();
        }
    }

}

