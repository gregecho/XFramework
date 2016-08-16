

namespace XFramework.Models
{

    // WFInstanceFlowStepRuns
    
    public class WfInstanceFlowStepRun
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
        /// StepStatus
        ///</summary>
        public int? StepStatus { get; set; }

        ///<summary>
        /// PlanStartDate
        ///</summary>
        public System.DateTime? PlanStartDate { get; set; }

        ///<summary>
        /// PlanEndDate
        ///</summary>
        public System.DateTime? PlanEndDate { get; set; }

        ///<summary>
        /// StepStartDate
        ///</summary>
        public System.DateTime? StepStartDate { get; set; }

        ///<summary>
        /// StepEndDate
        ///</summary>
        public System.DateTime? StepEndDate { get; set; }

        ///<summary>
        /// ObjectID
        ///</summary>
        public int? ObjectId { get; set; }

        ///<summary>
        /// ObjectType (length: 50)
        ///</summary>
        public string ObjectType { get; set; }

        ///<summary>
        /// SubFlowID
        ///</summary>
        public int? SubFlowId { get; set; }

        ///<summary>
        /// IsRemoved
        ///</summary>
        public bool IsRemoved { get; set; }

        ///<summary>
        /// LastModifyDate
        ///</summary>
        public System.DateTime? LastModifyDate { get; set; }

        ///<summary>
        /// OrderId
        ///</summary>
        public int? OrderId { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<WfFlagLog> WfFlagLogs { get; set; } // WFFlagLog.FK_WFFlagLog_WFInstanceFlowStepRuns
        public virtual System.Collections.Generic.ICollection<WfInstanceFlowStepRunField> WfInstanceFlowStepRunFields { get; set; } // WFInstanceFlowStepRunFields.FK_WFInstanceFlowStepRunFields_WFInstanceFlowStepRun
        public virtual System.Collections.Generic.ICollection<WfInstanceFlowStepUserRelation> WfInstanceFlowStepUserRelations { get; set; } // WFInstanceFlowStepUserRelations.FK_WFInstanceFlowStepUserRelations_WFInstanceFlowStepRuns
        public virtual System.Collections.Generic.ICollection<WfStepRunLog> WfStepRunLogs { get; set; } // WFStepRunLog.FK_WFStepRunLog_WFInstanceFlowStepRuns

        // Foreign keys
        public virtual WfInstanceFlowStep WfInstanceFlowStep { get; set; } // FK_WFInstanceFlowStepRun_WFInstanceFlowSteps

        public WfInstanceFlowStepRun()
        {
            IsRemoved = false;
            OrderId = 0;
            WfFlagLogs = new System.Collections.Generic.List<WfFlagLog>();
            WfInstanceFlowStepRunFields = new System.Collections.Generic.List<WfInstanceFlowStepRunField>();
            WfInstanceFlowStepUserRelations = new System.Collections.Generic.List<WfInstanceFlowStepUserRelation>();
            WfStepRunLogs = new System.Collections.Generic.List<WfStepRunLog>();
        }
    }

}

