

namespace XFramework.Models
{

    // WFFlowStepLines
    
    public class WfFlowStepLine
    {

        ///<summary>
        /// ID (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// FormID
        ///</summary>
        public int? FormId { get; set; }

        ///<summary>
        /// ToID
        ///</summary>
        public int? ToId { get; set; }

        ///<summary>
        /// Type (length: 50)
        ///</summary>
        public string Type { get; set; }

        // Foreign keys
        public virtual WfFlowStep Form { get; set; } // FK_WFFlowStepLines_WFFlowStepsForm
        public virtual WfFlowStep To { get; set; } // FK_WFFlowStepLines_WFFlowStepsTo
    }

}

