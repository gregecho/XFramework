

namespace XFramework.Models
{

    // WFCallbackLog
    
    public class WfCallbackLog
    {

        ///<summary>
        /// ID (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// ObjectID
        ///</summary>
        public int? ObjectId { get; set; }

        ///<summary>
        /// ObjectType (length: 50)
        ///</summary>
        public string ObjectType { get; set; }

        ///<summary>
        /// ResponseDateTime
        ///</summary>
        public System.DateTime? ResponseDateTime { get; set; }

        ///<summary>
        /// Name (length: 50)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// Status (length: 50)
        ///</summary>
        public string Status { get; set; }

        ///<summary>
        /// SubStatus (length: 50)
        ///</summary>
        public string SubStatus { get; set; }

        ///<summary>
        /// ResponseData
        ///</summary>
        public string ResponseData { get; set; }
    }

}

