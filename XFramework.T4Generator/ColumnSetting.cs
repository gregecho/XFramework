

namespace XFramework.Models
{

    // ColumnSettings
    
    public class ColumnSetting
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
        /// TableId
        ///</summary>
        public int TableId { get; set; }

        ///<summary>
        /// ColumnName
        ///</summary>
        public string ColumnName { get; set; }

        ///<summary>
        /// IsDisplay
        ///</summary>
        public bool IsDisplay { get; set; }

        ///<summary>
        /// DisplayName (length: 100)
        ///</summary>
        public string DisplayName { get; set; }

        ///<summary>
        /// IsExtend
        ///</summary>
        public bool IsExtend { get; set; }

        ///<summary>
        /// SortNumber
        ///</summary>
        public int? SortNumber { get; set; }

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
        /// Client
        ///</summary>
        public string Client { get; set; }

        ///<summary>
        /// ModelName
        ///</summary>
        public string ModelName { get; set; }

        ///<summary>
        /// FieldName
        ///</summary>
        public string FieldName { get; set; }

        ///<summary>
        /// IsNumber
        ///</summary>
        public string IsNumber { get; set; }

        ///<summary>
        /// Width
        ///</summary>
        public decimal Width { get; set; }

        ///<summary>
        /// ColNo
        ///</summary>
        public int ColNo { get; set; }

        ///<summary>
        /// ColSort
        ///</summary>
        public int ColSort { get; set; }

        ///<summary>
        /// IsEdit
        ///</summary>
        public bool IsEdit { get; set; }

        ///<summary>
        /// IsSearch
        ///</summary>
        public bool IsSearch { get; set; }

        ///<summary>
        /// ClientFormatFunc
        ///</summary>
        public string ClientFormatFunc { get; set; }

        ///<summary>
        /// ListSort
        ///</summary>
        public int ListSort { get; set; }

        public ColumnSetting()
        {
            Width = 0m;
            ColNo = 0;
            ColSort = 0;
            IsEdit = false;
            IsSearch = false;
            ListSort = 0;
        }
    }

}

