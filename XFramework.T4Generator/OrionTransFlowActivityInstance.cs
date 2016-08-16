

namespace XFramework.Models
{

    // OrionTransFlowActivityInstances
    
    public class OrionTransFlowActivityInstance
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// FlowInstanceId
        ///</summary>
        public int FlowInstanceId { get; set; }

        ///<summary>
        /// FlowActivityId
        ///</summary>
        public int FlowActivityId { get; set; }

        ///<summary>
        /// ProjectId
        ///</summary>
        public int ProjectId { get; set; }

        ///<summary>
        /// StartTime
        ///</summary>
        public System.DateTime StartTime { get; set; }

        ///<summary>
        /// EndTime
        ///</summary>
        public System.DateTime? EndTime { get; set; }

        ///<summary>
        /// OperatorId
        ///</summary>
        public int? OperatorId { get; set; }

        ///<summary>
        /// Status
        ///</summary>
        public int Status { get; set; }

        ///<summary>
        /// AssignToUser
        ///</summary>
        public int AssignToUser { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// NextFlowActivity_Id
        ///</summary>
        public int? NextFlowActivityId { get; set; }

        // Foreign keys
        public virtual OrionTransFlowActivity OrionTransFlowActivity { get; set; } // FK_dbo.OrionTransFlowActivityInstances_dbo.OrionTransFlowActivities_NextFlowActivity_Id
    }

}

