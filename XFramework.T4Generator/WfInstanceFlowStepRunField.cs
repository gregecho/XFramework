

namespace XFramework.Models
{

    // WFInstanceFlowStepRunFields
    
    public class WfInstanceFlowStepRunField
    {

        ///<summary>
        /// ID (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// WFInstanceFlowStepRunID
        ///</summary>
        public int WfInstanceFlowStepRunId { get; set; }

        ///<summary>
        /// Name (length: 50)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// Value
        ///</summary>
        public string Value { get; set; }

        // Foreign keys
        public virtual WfInstanceFlowStepRun WfInstanceFlowStepRun { get; set; } // FK_WFInstanceFlowStepRunFields_WFInstanceFlowStepRun
    }

}

