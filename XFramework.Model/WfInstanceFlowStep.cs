

namespace XFramework.Models
{

    // WFInstanceFlowSteps
    
    public class WfInstanceFlowStep
    {

        ///<summary>
        /// ID (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Name (length: 50)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// WFInstanceFlowID
        ///</summary>
        public int WfInstanceFlowId { get; set; }

        ///<summary>
        /// WFActivityID
        ///</summary>
        public int WfActivityId { get; set; }

        ///<summary>
        /// OrderID
        ///</summary>
        public int? OrderId { get; set; }

        ///<summary>
        /// DurationType (length: 50)
        ///</summary>
        public string DurationType { get; set; }

        ///<summary>
        /// Duration
        ///</summary>
        public int? Duration { get; set; }

        ///<summary>
        /// Delay
        ///</summary>
        public int? Delay { get; set; }

        ///<summary>
        /// PhaseID
        ///</summary>
        public int? PhaseId { get; set; }

        ///<summary>
        /// Expresssion
        ///</summary>
        public string Expresssion { get; set; }

        ///<summary>
        /// Condition
        ///</summary>
        public string Condition { get; set; }

        ///<summary>
        /// CustomFields
        ///</summary>
        public string CustomFields { get; set; }

        ///<summary>
        /// Description
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// CallbackExpresssion
        ///</summary>
        public string CallbackExpresssion { get; set; }

        ///<summary>
        /// StartDate
        ///</summary>
        public System.DateTime? StartDate { get; set; }

        ///<summary>
        /// EndDate
        ///</summary>
        public System.DateTime? EndDate { get; set; }

        ///<summary>
        /// StepStatus
        ///</summary>
        public int? StepStatus { get; set; }

        ///<summary>
        /// SubFlowID
        ///</summary>
        public int? SubFlowId { get; set; }

        ///<summary>
        /// RootFlowID
        ///</summary>
        public int? RootFlowId { get; set; }

        ///<summary>
        /// IsAutoAccept
        ///</summary>
        public bool IsAutoAccept { get; set; }

        ///<summary>
        /// LastModifyDate
        ///</summary>
        public System.DateTime? LastModifyDate { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<WfInstanceFlowStepLine> Form { get; set; } // WFInstanceFlowStepLines.FK_WFInstanceFlowStepLines_WFInstanceFlowStepsForm
        public virtual System.Collections.Generic.ICollection<WfInstanceFlowStepLine> To { get; set; } // WFInstanceFlowStepLines.FK_WFInstanceFlowStepLines_WFInstanceFlowStepsTo
        public virtual System.Collections.Generic.ICollection<WfInstanceFlowStepRun> WfInstanceFlowStepRuns { get; set; } // WFInstanceFlowStepRuns.FK_WFInstanceFlowStepRun_WFInstanceFlowSteps
        public virtual System.Collections.Generic.ICollection<WfInstanceFlowStepUserRelation> WfInstanceFlowStepUserRelations { get; set; } // WFInstanceFlowStepUserRelations.FK_WFInstanceFlowStepUserRelations_WFInstanceFlowSteps

        // Foreign keys
        public virtual WfActivity WfActivity { get; set; } // FK_WFInstanceFlowSteps_WFActivity
        public virtual WfInstanceFlow WfInstanceFlow { get; set; } // FK_WFInstanceFlowSteps_WFInstanceFlow

        public WfInstanceFlowStep()
        {
            IsDeleted = false;
            Form = new System.Collections.Generic.List<WfInstanceFlowStepLine>();
            To = new System.Collections.Generic.List<WfInstanceFlowStepLine>();
            WfInstanceFlowStepRuns = new System.Collections.Generic.List<WfInstanceFlowStepRun>();
            WfInstanceFlowStepUserRelations = new System.Collections.Generic.List<WfInstanceFlowStepUserRelation>();
        }
    }

}

