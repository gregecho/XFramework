

namespace XFramework.Models
{

    // ModelMappings
    
    public class ModelMapping
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
        /// MappingKey
        ///</summary>
        public string MappingKey { get; set; }

        ///<summary>
        /// ModelName
        ///</summary>
        public string ModelName { get; set; }

        ///<summary>
        /// ModelKey
        ///</summary>
        public string ModelKey { get; set; }

        ///<summary>
        /// FieldName
        ///</summary>
        public string FieldName { get; set; }

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
        /// CreatedByUser
        ///</summary>
        public int? CreatedByUser { get; set; }

        ///<summary>
        /// CreatedByName
        ///</summary>
        public string CreatedByName { get; set; }

        ///<summary>
        /// CreatedTime
        ///</summary>
        public System.DateTime? CreatedTime { get; set; }

        ///<summary>
        /// Comment
        ///</summary>
        public string Comment { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// ModelId
        ///</summary>
        public int ModelId { get; set; }

        ///<summary>
        /// FieldProperty
        ///</summary>
        public int FieldProperty { get; set; }

        ///<summary>
        /// SortNum
        ///</summary>
        public int SortNum { get; set; }

        ///<summary>
        /// EnableForTemplate
        ///</summary>
        public bool EnableForTemplate { get; set; }

        ///<summary>
        /// ControlType
        ///</summary>
        public int ControlType { get; set; }

        ///<summary>
        /// DataSource
        ///</summary>
        public string DataSource { get; set; }

        ///<summary>
        /// IsReadOnly
        ///</summary>
        public bool IsReadOnly { get; set; }

        ///<summary>
        /// EnableForColumnSetting
        ///</summary>
        public bool EnableForColumnSetting { get; set; }

        public ModelMapping()
        {
            ModelId = 0;
            FieldProperty = 0;
            SortNum = 0;
            EnableForTemplate = false;
            ControlType = 0;
            IsReadOnly = false;
            EnableForColumnSetting = false;
        }
    }

}

