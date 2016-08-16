

namespace XFramework.Models
{

    // UserGroups
    
    public class UserGroup
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// UserId
        ///</summary>
        public int UserId { get; set; }

        ///<summary>
        /// GroupId
        ///</summary>
        public int GroupId { get; set; }

        ///<summary>
        /// UserGroupEntityId
        ///</summary>
        public int UserGroupEntityId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// AccountId
        ///</summary>
        public int? AccountId { get; set; }

        ///<summary>
        /// Program
        ///</summary>
        public int? Program { get; set; }

        // Foreign keys
        public virtual UserGroupEntity UserGroupEntity { get; set; } // FK_dbo.UserGroups_dbo.UserGroupEntities_UserGroupEntityId
    }

}

