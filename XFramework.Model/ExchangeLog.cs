

namespace XFramework.Models
{

    // ExchangeLogs
    
    public class ExchangeLog
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Source
        ///</summary>
        public string Source { get; set; }

        ///<summary>
        /// Type
        ///</summary>
        public string Type { get; set; }

        ///<summary>
        /// LogType
        ///</summary>
        public string LogType { get; set; }

        ///<summary>
        /// ForeignId
        ///</summary>
        public int ForeignId { get; set; }

        ///<summary>
        /// CreateTime
        ///</summary>
        public System.DateTime CreateTime { get; set; }

        ///<summary>
        /// Info
        ///</summary>
        public string Info { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

