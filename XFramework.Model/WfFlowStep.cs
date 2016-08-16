

namespace XFramework.Models
{

    // WFFlowSteps
    
    public class WfFlowStep
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
        /// WFFlowTemplateID
        ///</summary>
        public int? WfFlowTemplateId { get; set; }

        ///<summary>
        /// SubFlowID
        ///</summary>
        public int? SubFlowId { get; set; }

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
        /// CallbackExpresssion
        ///</summary>
        public string CallbackExpresssion { get; set; }

        ///<summary>
        /// Description
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// IsAutoAccept
        ///</summary>
        public bool? IsAutoAccept { get; set; }

        ///<summary>
        /// FieldsType
        ///</summary>
        public int? FieldsType { get; set; }

        ///<summary>
        /// Creator
        ///</summary>
        public int? Creator { get; set; }

        ///<summary>
        /// FieldsLevel
        ///</summary>
        public int? FieldsLevel { get; set; }

        ///<summary>
        /// Customer
        ///</summary>
        public int? Customer { get; set; }

        ///<summary>
        /// StepPhase
        ///</summary>
        public int? StepPhase { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<WfFlowStepLine> Form { get; set; } // WFFlowStepLines.FK_WFFlowStepLines_WFFlowStepsForm
        public virtual System.Collections.Generic.ICollection<WfFlowStepLine> To { get; set; } // WFFlowStepLines.FK_WFFlowStepLines_WFFlowStepsTo
        public virtual System.Collections.Generic.ICollection<WfFlowStepUserRelation> WfFlowStepUserRelations { get; set; } // WFFlowStepUserRelations.FK_WFFlowStepUserRelations_WFFlowSteps

        // Foreign keys
        public virtual WfActivity WfActivity { get; set; } // FK_WFFlowSteps_WFActivity
        public virtual WfFlowTemplate WfFlowTemplate { get; set; } // FK_WFFlowSteps_WFFlowTemplate

        public WfFlowStep()
        {
            Form = new System.Collections.Generic.List<WfFlowStepLine>();
            To = new System.Collections.Generic.List<WfFlowStepLine>();
            WfFlowStepUserRelations = new System.Collections.Generic.List<WfFlowStepUserRelation>();
        }
    }

}

