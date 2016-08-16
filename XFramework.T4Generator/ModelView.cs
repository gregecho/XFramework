

namespace XFramework.Models
{

    // ModelViews
    
    public class ModelView
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

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
        /// ModelMappingKey
        ///</summary>
        public string ModelMappingKey { get; set; }

        ///<summary>
        /// ModelName
        ///</summary>
        public string ModelName { get; set; }

        ///<summary>
        /// ViewKey
        ///</summary>
        public string ViewKey { get; set; }

        ///<summary>
        /// ViewName
        ///</summary>
        public string ViewName { get; set; }

        ///<summary>
        /// DbFieldName
        ///</summary>
        public string DbFieldName { get; set; }

        ///<summary>
        /// MappingFieldName
        ///</summary>
        public string MappingFieldName { get; set; }

        ///<summary>
        /// DisplayName
        ///</summary>
        public string DisplayName { get; set; }

        ///<summary>
        /// DbType
        ///</summary>
        public string DbType { get; set; }

        ///<summary>
        /// SqlDbType
        ///</summary>
        public string SqlDbType { get; set; }

        ///<summary>
        /// IsRequired
        ///</summary>
        public bool IsRequired { get; set; }

        ///<summary>
        /// IsExtended
        ///</summary>
        public bool IsExtended { get; set; }

        ///<summary>
        /// FieldLevel
        ///</summary>
        public int FieldLevel { get; set; }

        ///<summary>
        /// SortNum
        ///</summary>
        public int SortNum { get; set; }

        ///<summary>
        /// Width
        ///</summary>
        public decimal Width { get; set; }

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
        /// ClientFormatFunc
        ///</summary>
        public string ClientFormatFunc { get; set; }

        ///<summary>
        /// ViewType
        ///</summary>
        public int ViewType { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// Component
        ///</summary>
        public int Component { get; set; }

        ///<summary>
        /// ModelId
        ///</summary>
        public int ModelId { get; set; }

        ///<summary>
        /// UserId
        ///</summary>
        public int UserId { get; set; }

        ///<summary>
        /// DataType
        ///</summary>
        public string DataType { get; set; }

        ///<summary>
        /// MapType
        ///</summary>
        public int MapType { get; set; }

        ///<summary>
        /// MapFieldId (length: 50)
        ///</summary>
        public string MapFieldId { get; set; }

        public ModelView()
        {
            ModelId = 0;
            UserId = 0;
            MapType = 0;
        }
    }

}

