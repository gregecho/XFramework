

namespace XFramework.Models
{

    // AdvanceFilters
    
    public class AdvanceFilter
    {

        ///<summary>
        /// ID (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Name (length: 500)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// CreateBy
        ///</summary>
        public int? CreateBy { get; set; }

        ///<summary>
        /// CreateTime
        ///</summary>
        public System.DateTime? CreateTime { get; set; }

        ///<summary>
        /// FilterClause
        ///</summary>
        public string FilterClause { get; set; }

        ///<summary>
        /// IsShare
        ///</summary>
        public bool? IsShare { get; set; }

        ///<summary>
        /// ShareId
        ///</summary>
        public int? ShareId { get; set; }

        ///<summary>
        /// TargetPage
        ///</summary>
        public int? TargetPage { get; set; }
    }

}

