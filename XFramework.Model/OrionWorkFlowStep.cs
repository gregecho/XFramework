

namespace XFramework.Models
{

    // OrionWorkFlowSteps
    
    public class OrionWorkFlowStep
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// WorkFlowId
        ///</summary>
        public int WorkFlowId { get; set; }

        ///<summary>
        /// StepId
        ///</summary>
        public int StepId { get; set; }

        ///<summary>
        /// Phase
        ///</summary>
        public int Phase { get; set; }

        ///<summary>
        /// StepNo
        ///</summary>
        public int StepNo { get; set; }

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

        // Foreign keys
        public virtual OrionStep OrionStep { get; set; } // FK_dbo.OrionWorkFlowSteps_dbo.OrionSteps_StepId

        public OrionWorkFlowStep()
        {
            IsHandOff = false;
            StepLevel = 0;
        }
    }

}

