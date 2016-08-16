

namespace XFramework.Models
{

    // OrionTransFlowInstances
    
    public class OrionTransFlowInstance
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// FlowId
        ///</summary>
        public int FlowId { get; set; }

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
        /// CreatorId
        ///</summary>
        public int CreatorId { get; set; }

        ///<summary>
        /// InstanceStatus
        ///</summary>
        public int InstanceStatus { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// CurrentFlowActivity_Id
        ///</summary>
        public int? CurrentFlowActivityId { get; set; }

        ///<summary>
        /// OrionTransPhase
        ///</summary>
        public int OrionTransPhase { get; set; }

        // Foreign keys
        public virtual OrionTransFlowActivity OrionTransFlowActivity { get; set; } // FK_dbo.OrionTransFlowInstances_dbo.OrionTransFlowActivities_CurrentFlowActivity_Id

        public OrionTransFlowInstance()
        {
            OrionTransPhase = 0;
        }
    }

}

