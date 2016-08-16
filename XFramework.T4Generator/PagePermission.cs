

namespace XFramework.Models
{

    // PagePermissions
    
    public class PagePermission
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// PageId
        ///</summary>
        public int PageId { get; set; }

        ///<summary>
        /// UserGroupEntityId
        ///</summary>
        public int UserGroupEntityId { get; set; }

        ///<summary>
        /// IsAccess
        ///</summary>
        public bool IsAccess { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Foreign keys
        public virtual Page Page { get; set; } // FK_dbo.PagePermissions_dbo.Pages_PageId
        public virtual UserGroupEntity UserGroupEntity { get; set; } // FK_dbo.PagePermissions_dbo.UserGroupEntities_UserGroupEntityId
    }

}

