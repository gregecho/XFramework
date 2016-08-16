

namespace XFramework.Models
{

    // OrionSteps
    
    public class OrionStep
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Name (length: 128)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// Comment (length: 1024)
        ///</summary>
        public string Comment { get; set; }

        ///<summary>
        /// StepType
        ///</summary>
        public int StepType { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// Duration
        ///</summary>
        public int? Duration { get; set; }

        ///<summary>
        /// DurationType
        ///</summary>
        public int? DurationType { get; set; }

        ///<summary>
        /// UnEditble
        ///</summary>
        public bool UnEditble { get; set; }

        ///<summary>
        /// SubStepNo
        ///</summary>
        public int? SubStepNo { get; set; }

        ///<summary>
        /// ParentId
        ///</summary>
        public int? ParentId { get; set; }

        ///<summary>
        /// IsHandOff
        ///</summary>
        public bool IsHandOff { get; set; }

        ///<summary>
        /// StepLevel
        ///</summary>
        public int StepLevel { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<OrionProjectWorkFlowStep> OrionProjectWorkFlowSteps { get; set; } // OrionProjectWorkFlowSteps.FK_dbo.OrionProjectWorkFlowSteps_dbo.OrionSteps_StepId
        public virtual System.Collections.Generic.ICollection<OrionWorkFlowStep> OrionWorkFlowSteps { get; set; } // OrionWorkFlowSteps.FK_dbo.OrionWorkFlowSteps_dbo.OrionSteps_StepId

        public OrionStep()
        {
            UnEditble = false;
            IsHandOff = false;
            StepLevel = 0;
            OrionProjectWorkFlowSteps = new System.Collections.Generic.List<OrionProjectWorkFlowStep>();
            OrionWorkFlowSteps = new System.Collections.Generic.List<OrionWorkFlowStep>();
        }
    }

}

