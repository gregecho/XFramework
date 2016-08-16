

namespace XFramework.Models
{

    // ApplicationTrackLogs
    
    public class ApplicationTrackLog
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// AppTrackName
        ///</summary>
        public string AppTrackName { get; set; }

        ///<summary>
        /// TrackSessionId
        ///</summary>
        public string TrackSessionId { get; set; }

        ///<summary>
        /// CreateTime
        ///</summary>
        public System.DateTime CreateTime { get; set; }

        ///<summary>
        /// Result
        ///</summary>
        public bool Result { get; set; }

        ///<summary>
        /// Message
        ///</summary>
        public string Message { get; set; }

        ///<summary>
        /// Stack
        ///</summary>
        public string Stack { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

