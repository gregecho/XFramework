

namespace XFramework.Models
{

    // Groups
    
    public class Group
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// UserGroupEntityId
        ///</summary>
        public int UserGroupEntityId { get; set; }

        ///<summary>
        /// Description (length: 1024)
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// DisableDuration
        ///</summary>
        public int? DisableDuration { get; set; }

        ///<summary>
        /// Name (length: 128)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// Code (length: 50)
        ///</summary>
        public string Code { get; set; }

        ///<summary>
        /// CreateBy
        ///</summary>
        public int? CreateBy { get; set; }

        ///<summary>
        /// CreateTime
        ///</summary>
        public System.DateTime? CreateTime { get; set; }

        // Foreign keys
        public virtual UserGroupEntity UserGroupEntity { get; set; } // FK_dbo.Groups_dbo.UserGroupEntities_UserGroupEntityId
    }

}

