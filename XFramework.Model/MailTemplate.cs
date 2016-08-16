

namespace XFramework.Models
{

    // MailTemplates
    
    public class MailTemplate
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// TemplateKey
        ///</summary>
        public string TemplateKey { get; set; }

        ///<summary>
        /// Attachments
        ///</summary>
        public string Attachments { get; set; }

        ///<summary>
        /// Sender
        ///</summary>
        public string Sender { get; set; }

        ///<summary>
        /// From
        ///</summary>
        public string From { get; set; }

        ///<summary>
        /// To
        ///</summary>
        public string To { get; set; }

        ///<summary>
        /// Bcc
        ///</summary>
        public string Bcc { get; set; }

        ///<summary>
        /// CC
        ///</summary>
        public string Cc { get; set; }

        ///<summary>
        /// Subject
        ///</summary>
        public string Subject { get; set; }

        ///<summary>
        /// Body
        ///</summary>
        public string Body { get; set; }

        ///<summary>
        /// IsBodyHtml
        ///</summary>
        public bool IsBodyHtml { get; set; }

        ///<summary>
        /// ServerId
        ///</summary>
        public int ServerId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

