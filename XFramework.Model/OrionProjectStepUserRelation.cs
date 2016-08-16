

namespace XFramework.Models
{

    // OrionProjectStepUserRelations
    
    public class OrionProjectStepUserRelation
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
        /// UserId
        ///</summary>
        public int UserId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// ProcessStatus
        ///</summary>
        public int ProcessStatus { get; set; }

        // Foreign keys
        public virtual User User { get; set; } // FK_dbo.OrionProjectStepUserRelations_dbo.Users_UserId

        public OrionProjectStepUserRelation()
        {
            ProcessStatus = 0;
        }
    }

}

