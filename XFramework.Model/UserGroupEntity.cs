

namespace XFramework.Models
{

    // UserGroupEntities
    
    public class UserGroupEntity
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// IsAdmin
        ///</summary>
        public bool IsAdmin { get; set; }

        ///<summary>
        /// EntityType
        ///</summary>
        public int EntityType { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<FieldPermission> FieldPermissions { get; set; } // FieldPermissions.FK_dbo.FieldPermissions_dbo.UserGroupEntities_UserGroupEntityId
        public virtual System.Collections.Generic.ICollection<Group> Groups { get; set; } // Groups.FK_dbo.Groups_dbo.UserGroupEntities_UserGroupEntityId
        public virtual System.Collections.Generic.ICollection<PagePermission> PagePermissions { get; set; } // PagePermissions.FK_dbo.PagePermissions_dbo.UserGroupEntities_UserGroupEntityId
        public virtual System.Collections.Generic.ICollection<User> Users { get; set; } // Users.FK_dbo.Users_dbo.UserGroupEntities_UserGroupEntityId
        public virtual System.Collections.Generic.ICollection<UserGroup> UserGroups { get; set; } // UserGroups.FK_dbo.UserGroups_dbo.UserGroupEntities_UserGroupEntityId

        public UserGroupEntity()
        {
            FieldPermissions = new System.Collections.Generic.List<FieldPermission>();
            Groups = new System.Collections.Generic.List<Group>();
            PagePermissions = new System.Collections.Generic.List<PagePermission>();
            UserGroups = new System.Collections.Generic.List<UserGroup>();
            Users = new System.Collections.Generic.List<User>();
        }
    }

}

