

namespace XFramework.Models
{

    // WFInstanceFlowStepUserRelations
    
    public class WfInstanceFlowStepUserRelation
    {

        ///<summary>
        /// ID (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// WFInstanceFlowStepID
        ///</summary>
        public int? WfInstanceFlowStepId { get; set; }

        ///<summary>
        /// WFInstanceFlowStepRunID
        ///</summary>
        public int? WfInstanceFlowStepRunId { get; set; }

        ///<summary>
        /// UserId
        ///</summary>
        public int UserId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// IsAccepted
        ///</summary>
        public int IsAccepted { get; set; }

        // Foreign keys
        public virtual User User { get; set; } // FK_WFInstanceFlowStepUserRelations_Users
        public virtual WfInstanceFlowStep WfInstanceFlowStep { get; set; } // FK_WFInstanceFlowStepUserRelations_WFInstanceFlowSteps
        public virtual WfInstanceFlowStepRun WfInstanceFlowStepRun { get; set; } // FK_WFInstanceFlowStepUserRelations_WFInstanceFlowStepRuns
    }

}

