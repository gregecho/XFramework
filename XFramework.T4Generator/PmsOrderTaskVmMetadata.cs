

namespace XFramework.Models
{

    // PMSOrderTaskVMMetadatas
    
    public class PmsOrderTaskVmMetadata
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// ColumnName (length: 100)
        ///</summary>
        public string ColumnName { get; set; }

        ///<summary>
        /// ColumnHeader (length: 100)
        ///</summary>
        public string ColumnHeader { get; set; }

        ///<summary>
        /// ColumnClientFormatFunc (length: 100)
        ///</summary>
        public string ColumnClientFormatFunc { get; set; }

        ///<summary>
        /// SortOrderTag
        ///</summary>
        public int SortOrderTag { get; set; }

        ///<summary>
        /// ModelName
        ///</summary>
        public string ModelName { get; set; }

        ///<summary>
        /// FilterOrGrid
        ///</summary>
        public string FilterOrGrid { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

