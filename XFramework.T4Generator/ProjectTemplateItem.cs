

namespace XFramework.Models
{

    // ProjectTemplateItems
    
    public class ProjectTemplateItem
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Component
        ///</summary>
        public int Component { get; set; }

        ///<summary>
        /// ClientId
        ///</summary>
        public int ClientId { get; set; }

        ///<summary>
        /// Client
        ///</summary>
        public string Client { get; set; }

        ///<summary>
        /// ModelMappingId
        ///</summary>
        public int ModelMappingId { get; set; }

        ///<summary>
        /// ModelId
        ///</summary>
        public int ModelId { get; set; }

        ///<summary>
        /// ModelName
        ///</summary>
        public string ModelName { get; set; }

        ///<summary>
        /// DbFieldName
        ///</summary>
        public string DbFieldName { get; set; }

        ///<summary>
        /// DisplayName
        ///</summary>
        public string DisplayName { get; set; }

        ///<summary>
        /// IsRequired
        ///</summary>
        public bool IsRequired { get; set; }

        ///<summary>
        /// IsExtended
        ///</summary>
        public bool IsExtended { get; set; }

        ///<summary>
        /// IsDisplay
        ///</summary>
        public bool IsDisplay { get; set; }

        ///<summary>
        /// CreatedBy
        ///</summary>
        public int? CreatedBy { get; set; }

        ///<summary>
        /// CreatedByUser
        ///</summary>
        public string CreatedByUser { get; set; }

        ///<summary>
        /// CreatedTime
        ///</summary>
        public System.DateTime? CreatedTime { get; set; }

        ///<summary>
        /// Comment
        ///</summary>
        public string Comment { get; set; }

        ///<summary>
        /// ColNum
        ///</summary>
        public int ColNum { get; set; }

        ///<summary>
        /// ColSort
        ///</summary>
        public int ColSort { get; set; }

        ///<summary>
        /// Value
        ///</summary>
        public string Value { get; set; }

        ///<summary>
        /// ViewId
        ///</summary>
        public int ViewId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// TemplateId
        ///</summary>
        public int TemplateId { get; set; }

        ///<summary>
        /// ModelKey
        ///</summary>
        public string ModelKey { get; set; }

        public ProjectTemplateItem()
        {
            TemplateId = 0;
        }
    }

}

