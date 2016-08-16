

namespace XFramework.Models
{

    // OrionProjectFlowStatusRecords
    
    public class OrionProjectFlowStatusRecord
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// ProjectFlowCurrentStatusId
        ///</summary>
        public int ProjectFlowCurrentStatusId { get; set; }

        ///<summary>
        /// ProcessTime
        ///</summary>
        public System.DateTime ProcessTime { get; set; }

        ///<summary>
        /// ProcessId
        ///</summary>
        public int ProcessId { get; set; }

        ///<summary>
        /// ProcessedType
        ///</summary>
        public int ProcessedType { get; set; }

        ///<summary>
        /// Comment
        ///</summary>
        public string Comment { get; set; }

        ///<summary>
        /// IsCompleted
        ///</summary>
        public bool IsCompleted { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

