

namespace XFramework.Models
{

    // WFFlowStepStandardField
    
    public class WfFlowStepStandardField
    {

        ///<summary>
        /// ID (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// FieldsName (length: 50)
        ///</summary>
        public string FieldsName { get; set; }

        ///<summary>
        /// DisplayName (length: 50)
        ///</summary>
        public string DisplayName { get; set; }

        ///<summary>
        /// MappingName (length: 50)
        ///</summary>
        public string MappingName { get; set; }

        ///<summary>
        /// ControlType
        ///</summary>
        public int ControlType { get; set; }

        ///<summary>
        /// FieldsType
        ///</summary>
        public int? FieldsType { get; set; }

        ///<summary>
        /// DataSource (length: 50)
        ///</summary>
        public string DataSource { get; set; }

        ///<summary>
        /// IsRequired
        ///</summary>
        public bool IsRequired { get; set; }

        ///<summary>
        /// IsReadOnly
        ///</summary>
        public bool IsReadOnly { get; set; }

        ///<summary>
        /// DefaultFieldsValue (length: 200)
        ///</summary>
        public string DefaultFieldsValue { get; set; }

        ///<summary>
        /// FieldsLevel
        ///</summary>
        public int? FieldsLevel { get; set; }

        ///<summary>
        /// Customer
        ///</summary>
        public int? Customer { get; set; }

        ///<summary>
        /// Creator
        ///</summary>
        public int? Creator { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

