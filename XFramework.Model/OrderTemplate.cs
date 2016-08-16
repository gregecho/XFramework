

namespace XFramework.Models
{

    // OrderTemplates
    
    public class OrderTemplate
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Name (length: 150)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// PrjStatusId
        ///</summary>
        public int? PrjStatusId { get; set; }

        ///<summary>
        /// MSContactId
        ///</summary>
        public int? MsContactId { get; set; }

        ///<summary>
        /// LIOXContactId
        ///</summary>
        public int? LioxContactId { get; set; }

        ///<summary>
        /// ProductId
        ///</summary>
        public int? ProductId { get; set; }

        ///<summary>
        /// CategoryId
        ///</summary>
        public int? CategoryId { get; set; }

        ///<summary>
        /// FamilyId
        ///</summary>
        public int? FamilyId { get; set; }

        ///<summary>
        /// CreatedBy
        ///</summary>
        public int? CreatedBy { get; set; }

        ///<summary>
        /// CreatedOn
        ///</summary>
        public System.DateTime? CreatedOn { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// CCIOId
        ///</summary>
        public int? CcioId { get; set; }

        ///<summary>
        /// GLCodeId
        ///</summary>
        public int? GlCodeId { get; set; }

        ///<summary>
        /// ReleaseId
        ///</summary>
        public int? ReleaseId { get; set; }

        ///<summary>
        /// TaskTypeId
        ///</summary>
        public int? TaskTypeId { get; set; }

        ///<summary>
        /// DescriptionId
        ///</summary>
        public int? DescriptionId { get; set; }

        ///<summary>
        /// ProjId
        ///</summary>
        public string ProjId { get; set; }
    }

}

