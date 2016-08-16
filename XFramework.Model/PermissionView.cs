

namespace XFramework.Models
{

    // permissionViews
    
    public class PermissionView
    {

        ///<summary>
        /// Id
        ///</summary>
        public int? Id { get; set; }

        ///<summary>
        /// customerId
        ///</summary>
        public int CustomerId { get; set; }

        ///<summary>
        /// customer
        ///</summary>
        public string Customer { get; set; }

        ///<summary>
        /// programId
        ///</summary>
        public int ProgramId { get; set; }

        ///<summary>
        /// program
        ///</summary>
        public string Program { get; set; }

        ///<summary>
        /// roleId
        ///</summary>
        public int RoleId { get; set; }

        ///<summary>
        /// role (length: 128)
        ///</summary>
        public string Role { get; set; }

        ///<summary>
        /// userId
        ///</summary>
        public int UserId { get; set; }

        ///<summary>
        /// user (length: 128)
        ///</summary>
        public string User { get; set; }

        ///<summary>
        /// pageId
        ///</summary>
        public int PageId { get; set; }

        ///<summary>
        /// page (length: 128)
        ///</summary>
        public string Page { get; set; }

        ///<summary>
        /// pageType
        ///</summary>
        public int? PageType { get; set; }
    }

}

