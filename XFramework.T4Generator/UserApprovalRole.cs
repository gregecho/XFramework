

namespace XFramework.Models
{

    // UserApprovalRoles
    
    public class UserApprovalRole
    {

        ///<summary>
        /// ID (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// RoleId
        ///</summary>
        public int RoleId { get; set; }

        ///<summary>
        /// UserApprovalId
        ///</summary>
        public int UserApprovalId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool? IsDeleted { get; set; }

        // Foreign keys
        public virtual UserApproval UserApproval { get; set; } // FK_UserApprovalRoles_UserApproval
    }

}

