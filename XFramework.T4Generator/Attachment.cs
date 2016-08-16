

namespace XFramework.Models
{

    // Attachments
    
    public class Attachment
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// ForeignKeyId
        ///</summary>
        public int ForeignKeyId { get; set; }

        ///<summary>
        /// FileName (length: 256)
        ///</summary>
        public string FileName { get; set; }

        ///<summary>
        /// Content
        ///</summary>
        public byte[] Content { get; set; }

        ///<summary>
        /// CreatedDate
        ///</summary>
        public System.DateTime CreatedDate { get; set; }

        ///<summary>
        /// GuidDirectory (length: 64)
        ///</summary>
        public string GuidDirectory { get; set; }

        ///<summary>
        /// AttachType (length: 64)
        ///</summary>
        public string AttachType { get; set; }

        ///<summary>
        /// FileSize
        ///</summary>
        public double FileSize { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

