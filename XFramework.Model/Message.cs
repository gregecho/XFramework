

namespace XFramework.Models
{

    // Messages
    
    public class Message
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Title (length: 200)
        ///</summary>
        public string Title { get; set; }

        ///<summary>
        /// Content (length: 2000)
        ///</summary>
        public string Content { get; set; }

        ///<summary>
        /// isread
        ///</summary>
        public byte Isread { get; set; }

        ///<summary>
        /// sendtime
        ///</summary>
        public System.DateTime Sendtime { get; set; }

        ///<summary>
        /// sender
        ///</summary>
        public int Sender { get; set; }

        ///<summary>
        /// receiver
        ///</summary>
        public int Receiver { get; set; }

        ///<summary>
        /// isFlag
        ///</summary>
        public bool IsFlag { get; set; }

        ///<summary>
        /// isClosed
        ///</summary>
        public bool IsClosed { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

