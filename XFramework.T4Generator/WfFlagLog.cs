

namespace XFramework.Models
{

    // WFFlagLog
    
    public class WfFlagLog
    {

        ///<summary>
        /// ID (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// WFInstanceFlowID
        ///</summary>
        public int? WfInstanceFlowId { get; set; }

        ///<summary>
        /// StepRunID
        ///</summary>
        public int? StepRunId { get; set; }

        ///<summary>
        /// Flag
        ///</summary>
        public int Flag { get; set; }

        ///<summary>
        /// IsActive
        ///</summary>
        public bool IsActive { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// LogContent (length: 2000)
        ///</summary>
        public string LogContent { get; set; }

        ///<summary>
        /// CreateTime
        ///</summary>
        public System.DateTime? CreateTime { get; set; }

        // Foreign keys
        public virtual WfFlagConfig WfFlagConfig { get; set; } // FK_WFFlagLog_WFFlagConfig
        public virtual WfInstanceFlow WfInstanceFlow { get; set; } // FK_WFFlagLog_WFInstanceFlows
        public virtual WfInstanceFlowStepRun WfInstanceFlowStepRun { get; set; } // FK_WFFlagLog_WFInstanceFlowStepRuns
    }

}

