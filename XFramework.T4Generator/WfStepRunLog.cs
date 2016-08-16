

namespace XFramework.Models
{

    // WFStepRunLog
    
    public class WfStepRunLog
    {

        ///<summary>
        /// ID (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// UserId
        ///</summary>
        public int? UserId { get; set; }

        ///<summary>
        /// EventType (length: 50)
        ///</summary>
        public string EventType { get; set; }

        ///<summary>
        /// OperateTime
        ///</summary>
        public System.DateTime? OperateTime { get; set; }

        ///<summary>
        /// ProjectId
        ///</summary>
        public int? ProjectId { get; set; }

        ///<summary>
        /// WFInstanceFlowStepRunId
        ///</summary>
        public int? WfInstanceFlowStepRunId { get; set; }

        // Foreign keys
        public virtual PmsOrder PmsOrder { get; set; } // FK_WFStepRunLog_PMSOrders
        public virtual User User { get; set; } // FK_WFStepRunLog_Users
        public virtual WfInstanceFlowStepRun WfInstanceFlowStepRun { get; set; } // FK_WFStepRunLog_WFInstanceFlowStepRuns
    }

}

