

namespace XFramework.Models
{

    // UserApproval
    
    public class UserApproval
    {

        ///<summary>
        /// ID (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// UserId
        ///</summary>
        public int UserId { get; set; }

        ///<summary>
        /// AccountId
        ///</summary>
        public int AccountId { get; set; }

        ///<summary>
        /// ProgramId
        ///</summary>
        public int ProgramId { get; set; }

        ///<summary>
        /// Status (length: 50)
        ///</summary>
        public string Status { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool? IsDeleted { get; set; }

        ///<summary>
        /// CreatedBy
        ///</summary>
        public int? CreatedBy { get; set; }

        ///<summary>
        /// CreatedTime
        ///</summary>
        public System.DateTime? CreatedTime { get; set; }

        ///<summary>
        /// CompletedBy
        ///</summary>
        public int? CompletedBy { get; set; }

        ///<summary>
        /// CompletedTime
        ///</summary>
        public System.DateTime? CompletedTime { get; set; }

        ///<summary>
        /// IsApproved
        ///</summary>
        public bool? IsApproved { get; set; }

        ///<summary>
        /// Description
        ///</summary>
        public string Description { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<UserApprovalRole> UserApprovalRoles { get; set; } // UserApprovalRoles.FK_UserApprovalRoles_UserApproval

        public UserApproval()
        {
            UserApprovalRoles = new System.Collections.Generic.List<UserApprovalRole>();
        }
    }

}

