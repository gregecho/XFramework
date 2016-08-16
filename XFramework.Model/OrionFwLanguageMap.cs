

namespace XFramework.Models
{

    // OrionFwLanguageMaps
    
    public class OrionFwLanguageMap
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// FwLanguageId
        ///</summary>
        public string FwLanguageId { get; set; }

        ///<summary>
        /// FwLangDescription
        ///</summary>
        public string FwLangDescription { get; set; }

        ///<summary>
        /// ISOLanguageCode
        ///</summary>
        public string IsoLanguageCode { get; set; }

        ///<summary>
        /// OrionLanguageId
        ///</summary>
        public int? OrionLanguageId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

