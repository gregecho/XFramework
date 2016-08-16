

namespace XFramework.Models
{

    // SMTPServers
    
    public class SmtpServer
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// ServerName (length: 128)
        ///</summary>
        public string ServerName { get; set; }

        ///<summary>
        /// Description (length: 512)
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// Port
        ///</summary>
        public short Port { get; set; }

        ///<summary>
        /// Encryption
        ///</summary>
        public int Encryption { get; set; }

        ///<summary>
        /// Email (length: 256)
        ///</summary>
        public string Email { get; set; }

        ///<summary>
        /// IsAuthentication
        ///</summary>
        public bool IsAuthentication { get; set; }

        ///<summary>
        /// UserName (length: 128)
        ///</summary>
        public string UserName { get; set; }

        ///<summary>
        /// Password (length: 256)
        ///</summary>
        public string Password { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

