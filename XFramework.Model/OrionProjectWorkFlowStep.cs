

namespace XFramework.Models
{

    // OrionProjectWorkFlowSteps
    
    public class OrionProjectWorkFlowStep
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
        /// StartDate
        ///</summary>
        public System.DateTime? StartDate { get; set; }

        ///<summary>
        /// EndDate
        ///</summary>
        public System.DateTime? EndDate { get; set; }

        ///<summary>
        /// WorkFlowStepId
        ///</summary>
        public int WorkFlowStepId { get; set; }

        ///<summary>
        /// ProjectId
        ///</summary>
        public int ProjectId { get; set; }

        ///<summary>
        /// StepStatus
        ///</summary>
        public int StepStatus { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// ChildProjectId
        ///</summary>
        public int? ChildProjectId { get; set; }

        ///<summary>
        /// StepDescription
        ///</summary>
        public string StepDescription { get; set; }

        ///<summary>
        /// ExpectedStartDate
        ///</summary>
        public System.DateTime? ExpectedStartDate { get; set; }

        ///<summary>
        /// ExpectedEndDate
        ///</summary>
        public System.DateTime? ExpectedEndDate { get; set; }

        ///<summary>
        /// OrderStatus
        ///</summary>
        public string OrderStatus { get; set; }

        ///<summary>
        /// Flag
        ///</summary>
        public string Flag { get; set; }

        ///<summary>
        /// IsHandOff
        ///</summary>
        public bool IsHandOff { get; set; }

        ///<summary>
        /// AssociatedId
        ///</summary>
        public int? AssociatedId { get; set; }

        ///<summary>
        /// StepLevel
        ///</summary>
        public int StepLevel { get; set; }

        ///<summary>
        /// ParentId
        ///</summary>
        public int ParentId { get; set; }

        // Foreign keys
        public virtual OrionStep OrionStep { get; set; } // FK_dbo.OrionProjectWorkFlowSteps_dbo.OrionSteps_StepId

        public OrionProjectWorkFlowStep()
        {
            IsHandOff = false;
            StepLevel = 0;
            ParentId = 0;
        }
    }

}

