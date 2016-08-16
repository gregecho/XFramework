

namespace XFramework.Models
{

    // OrionWorkFlowStepUserRelations
    
    public class OrionWorkFlowStepUserRelation
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// WorkFlowStepId
        ///</summary>
        public int WorkFlowStepId { get; set; }

        ///<summary>
        /// UserId
        ///</summary>
        public int UserId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Foreign keys
        public virtual User User { get; set; } // FK_dbo.OrionWorkFlowStepUserRelations_dbo.Users_UserId
    }

}

