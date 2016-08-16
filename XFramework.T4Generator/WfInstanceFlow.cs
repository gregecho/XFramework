

namespace XFramework.Models
{

    // WFInstanceFlows
    
    public class WfInstanceFlow
    {

        ///<summary>
        /// ID (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// ProcessName (length: 50)
        ///</summary>
        public string ProcessName { get; set; }

        ///<summary>
        /// ProcessObject (length: 50)
        ///</summary>
        public string ProcessObject { get; set; }

        ///<summary>
        /// AccountId
        ///</summary>
        public int AccountId { get; set; }

        ///<summary>
        /// WorkFlowType
        ///</summary>
        public int WorkFlowType { get; set; }

        ///<summary>
        /// Status
        ///</summary>
        public int Status { get; set; }

        ///<summary>
        /// Description
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// CreatorId
        ///</summary>
        public int CreatorId { get; set; }

        ///<summary>
        /// CreateDate
        ///</summary>
        public System.DateTime CreateDate { get; set; }

        ///<summary>
        /// ModifierId
        ///</summary>
        public int? ModifierId { get; set; }

        ///<summary>
        /// LastModifyDate
        ///</summary>
        public System.DateTime? LastModifyDate { get; set; }

        ///<summary>
        /// StartDate
        ///</summary>
        public System.DateTime? StartDate { get; set; }

        ///<summary>
        /// ObjectID
        ///</summary>
        public int ObjectId { get; set; }

        ///<summary>
        /// IsAutoStart
        ///</summary>
        public bool? IsAutoStart { get; set; }

        ///<summary>
        /// RootFlowID
        ///</summary>
        public int? RootFlowId { get; set; }

        ///<summary>
        /// ParentStepRunID
        ///</summary>
        public int? ParentStepRunId { get; set; }

        ///<summary>
        /// LazyLoad
        ///</summary>
        public bool LazyLoad { get; set; }

        ///<summary>
        /// DelayLoad
        ///</summary>
        public bool DelayLoad { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<WfFlagLog> WfFlagLogs { get; set; } // WFFlagLog.FK_WFFlagLog_WFInstanceFlows
        public virtual System.Collections.Generic.ICollection<WfInstanceFlowStep> WfInstanceFlowSteps { get; set; } // WFInstanceFlowSteps.FK_WFInstanceFlowSteps_WFInstanceFlow

        public WfInstanceFlow()
        {
            LazyLoad = false;
            DelayLoad = false;
            WfFlagLogs = new System.Collections.Generic.List<WfFlagLog>();
            WfInstanceFlowSteps = new System.Collections.Generic.List<WfInstanceFlowStep>();
        }
    }

}

