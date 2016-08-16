

namespace XFramework.Models
{

    // OrionProjectFlowCurrentStatus
    
    public class OrionProjectFlowCurrentStatu
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// ProjectWorkFlowStepId
        ///</summary>
        public int ProjectWorkFlowStepId { get; set; }

        ///<summary>
        /// WorkFlowId
        ///</summary>
        public int WorkFlowId { get; set; }

        ///<summary>
        /// ProjectId
        ///</summary>
        public int ProjectId { get; set; }

        ///<summary>
        /// ProjectOwnerId
        ///</summary>
        public int ProjectOwnerId { get; set; }

        ///<summary>
        /// LastOperateTime
        ///</summary>
        public System.DateTime LastOperateTime { get; set; }

        ///<summary>
        /// ProjectWorkFlowStatus
        ///</summary>
        public int ProjectWorkFlowStatus { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

