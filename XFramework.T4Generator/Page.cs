

namespace XFramework.Models
{

    // Pages
    
    public class Page
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
        /// Module
        ///</summary>
        public int Module { get; set; }

        ///<summary>
        /// SortOrder
        ///</summary>
        public int SortOrder { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// PageType
        ///</summary>
        public int? PageType { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<PagePermission> PagePermissions { get; set; } // PagePermissions.FK_dbo.PagePermissions_dbo.Pages_PageId

        public Page()
        {
            PagePermissions = new System.Collections.Generic.List<PagePermission>();
        }
    }

}

