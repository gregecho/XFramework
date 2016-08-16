

namespace XFramework.Models
{

    // WFFlowStepUserRelations
    
    public class WfFlowStepUserRelation
    {

        ///<summary>
        /// ID (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// WFFlowStepID
        ///</summary>
        public int WfFlowStepId { get; set; }

        ///<summary>
        /// UserId
        ///</summary>
        public int UserId { get; set; }

        // Foreign keys
        public virtual User User { get; set; } // FK_dbo_WFFlowStepUserRelations_dbo_Users_UserId
        public virtual WfFlowStep WfFlowStep { get; set; } // FK_WFFlowStepUserRelations_WFFlowSteps
    }

}

