

namespace XFramework.Models
{

    // DictDatas
    
    public class DictData
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Name (length: 128)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// DictTypeId
        ///</summary>
        public int DictTypeId { get; set; }

        ///<summary>
        /// ParentId
        ///</summary>
        public int ParentId { get; set; }

        ///<summary>
        /// Description (length: 1024)
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Foreign keys
        public virtual DictType DictType { get; set; } // FK_dbo.DictDatas_dbo.DictTypes_DictTypeId
    }

}

