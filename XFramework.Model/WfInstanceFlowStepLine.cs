

namespace XFramework.Models
{

    // WFInstanceFlowStepLines
    
    public class WfInstanceFlowStepLine
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
        public virtual WfInstanceFlowStep Form { get; set; } // FK_WFInstanceFlowStepLines_WFInstanceFlowStepsForm
        public virtual WfInstanceFlowStep To { get; set; } // FK_WFInstanceFlowStepLines_WFInstanceFlowStepsTo
    }

}

