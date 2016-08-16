

namespace XFramework.Models
{

    // OrionMessages
    
    public class OrionMessage
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Title
        ///</summary>
        public string Title { get; set; }

        ///<summary>
        /// Content
        ///</summary>
        public string Content { get; set; }

        ///<summary>
        /// IsRead
        ///</summary>
        public int IsRead { get; set; }

        ///<summary>
        /// SendTime
        ///</summary>
        public System.DateTime SendTime { get; set; }

        ///<summary>
        /// Sender
        ///</summary>
        public int Sender { get; set; }

        ///<summary>
        /// Receiver
        ///</summary>
        public int Receiver { get; set; }

        ///<summary>
        /// ProjectId
        ///</summary>
        public int? ProjectId { get; set; }

        ///<summary>
        /// MessageType
        ///</summary>
        public int MessageType { get; set; }

        ///<summary>
        /// IsDeletedByAuthor
        ///</summary>
        public bool IsDeletedByAuthor { get; set; }

        ///<summary>
        /// IsDeletedByRecipient
        ///</summary>
        public bool IsDeletedByRecipient { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// stepId
        ///</summary>
        public int? StepId { get; set; }

        ///<summary>
        /// Flag
        ///</summary>
        public string Flag { get; set; }

        ///<summary>
        /// RecipientType
        ///</summary>
        public int RecipientType { get; set; }

        public OrionMessage()
        {
            StepId = 0;
            RecipientType = 5;
        }
    }

}

