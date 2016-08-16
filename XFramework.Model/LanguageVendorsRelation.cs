

namespace XFramework.Models
{

    // LanguageVendorsRelations
    
    public class LanguageVendorsRelation
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Language
        ///</summary>
        public int Language { get; set; }

        ///<summary>
        /// Vendor
        ///</summary>
        public int Vendor { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

