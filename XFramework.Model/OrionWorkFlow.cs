

namespace XFramework.Models
{

    // OrionWorkFlows
    
    public class OrionWorkFlow
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
        /// CreatorId
        ///</summary>
        public int CreatorId { get; set; }

        ///<summary>
        /// CreateDate
        ///</summary>
        public System.DateTime CreateDate { get; set; }

        ///<summary>
        /// Status
        ///</summary>
        public int Status { get; set; }

        ///<summary>
        /// ModifierId
        ///</summary>
        public int ModifierId { get; set; }

        ///<summary>
        /// LastModifyDate
        ///</summary>
        public System.DateTime LastModifyDate { get; set; }

        ///<summary>
        /// AccountId
        ///</summary>
        public int AccountId { get; set; }

        ///<summary>
        /// Comment (length: 1024)
        ///</summary>
        public string Comment { get; set; }

        ///<summary>
        /// WorkFlowType
        ///</summary>
        public int WorkFlowType { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// ContainTMS
        ///</summary>
        public bool ContainTms { get; set; }

        ///<summary>
        /// IsAutoGenerateHandOff
        ///</summary>
        public bool IsAutoGenerateHandOff { get; set; }

        public OrionWorkFlow()
        {
            ContainTms = false;
            IsAutoGenerateHandOff = false;
        }
    }

}

