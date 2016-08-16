

namespace XFramework.Models
{

    // TransactionLogs
    
    public class TransactionLog
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// UserName
        ///</summary>
        public string UserName { get; set; }

        ///<summary>
        /// ActionType
        ///</summary>
        public int ActionType { get; set; }

        ///<summary>
        /// OldData
        ///</summary>
        public string OldData { get; set; }

        ///<summary>
        /// NewData
        ///</summary>
        public string NewData { get; set; }

        ///<summary>
        /// Timestamp
        ///</summary>
        public System.DateTime Timestamp { get; set; }

        ///<summary>
        /// IPAddress
        ///</summary>
        public string IpAddress { get; set; }

        ///<summary>
        /// HTTPInfo
        ///</summary>
        public string HttpInfo { get; set; }

        ///<summary>
        /// Status
        ///</summary>
        public bool Status { get; set; }

        ///<summary>
        /// AdditionInfo
        ///</summary>
        public string AdditionInfo { get; set; }

        ///<summary>
        /// TableName (length: 128)
        ///</summary>
        public string TableName { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

