

namespace XFramework.Models
{

    // DictTypes
    
    public class DictType
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
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// Category
        ///</summary>
        public int Category { get; set; }

        ///<summary>
        /// Description
        ///</summary>
        public string Description { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<DictData> DictDatas { get; set; } // DictDatas.FK_dbo.DictDatas_dbo.DictTypes_DictTypeId

        public DictType()
        {
            Category = 1;
            DictDatas = new System.Collections.Generic.List<DictData>();
        }
    }

}

