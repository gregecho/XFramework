

namespace XFramework.Models
{

    // OrionProjectWorkFlowStepTasks
    
    public class OrionProjectWorkFlowStepTask
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
        /// ProjectId
        ///</summary>
        public int ProjectId { get; set; }

        ///<summary>
        /// WorkFlowId
        ///</summary>
        public int WorkFlowId { get; set; }

        ///<summary>
        /// OwnerId
        ///</summary>
        public int OwnerId { get; set; }

        ///<summary>
        /// Creator
        ///</summary>
        public int Creator { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// Status
        ///</summary>
        public int Status { get; set; }

        public OrionProjectWorkFlowStepTask()
        {
            Status = 0;
        }
    }

}

