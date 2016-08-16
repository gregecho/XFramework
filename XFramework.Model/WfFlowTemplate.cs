

namespace XFramework.Models
{

    // WFFlowTemplates
    
    public class WfFlowTemplate
    {

        ///<summary>
        /// ID (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// ProcessName (length: 50)
        ///</summary>
        public string ProcessName { get; set; }

        ///<summary>
        /// ProcessObject (length: 50)
        ///</summary>
        public string ProcessObject { get; set; }

        ///<summary>
        /// AccountId
        ///</summary>
        public int AccountId { get; set; }

        ///<summary>
        /// WorkFlowType
        ///</summary>
        public int WorkFlowType { get; set; }

        ///<summary>
        /// Status
        ///</summary>
        public int Status { get; set; }

        ///<summary>
        /// Description
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// CreatorId
        ///</summary>
        public int CreatorId { get; set; }

        ///<summary>
        /// CreateDate
        ///</summary>
        public System.DateTime CreateDate { get; set; }

        ///<summary>
        /// ModifierId
        ///</summary>
        public int? ModifierId { get; set; }

        ///<summary>
        /// LastModifyDate
        ///</summary>
        public System.DateTime? LastModifyDate { get; set; }

        ///<summary>
        /// IsAutoStart
        ///</summary>
        public bool? IsAutoStart { get; set; }

        ///<summary>
        /// LazyLoad
        ///</summary>
        public bool LazyLoad { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<WfFlowStep> WfFlowSteps { get; set; } // WFFlowSteps.FK_WFFlowSteps_WFFlowTemplate

        public WfFlowTemplate()
        {
            LazyLoad = false;
            WfFlowSteps = new System.Collections.Generic.List<WfFlowStep>();
        }
    }

}

