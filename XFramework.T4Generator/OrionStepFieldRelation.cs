

namespace XFramework.Models
{

    // OrionStepFieldRelations
    
    public class OrionStepFieldRelation
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// StepId
        ///</summary>
        public int StepId { get; set; }

        ///<summary>
        /// ModelMappingId
        ///</summary>
        public int ModelMappingId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// CanEdit
        ///</summary>
        public bool CanEdit { get; set; }

        ///<summary>
        /// WorkflowStepId
        ///</summary>
        public int WorkflowStepId { get; set; }

        ///<summary>
        /// IsWorkflowStepDefined
        ///</summary>
        public bool IsWorkflowStepDefined { get; set; }

        public OrionStepFieldRelation()
        {
            CanEdit = false;
            WorkflowStepId = 0;
            IsWorkflowStepDefined = false;
        }
    }

}

