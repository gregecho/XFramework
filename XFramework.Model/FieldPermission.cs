

namespace XFramework.Models
{

    // FieldPermissions
    
    public class FieldPermission
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// FieldId
        ///</summary>
        public int FieldId { get; set; }

        ///<summary>
        /// UserGroupEntityId
        ///</summary>
        public int UserGroupEntityId { get; set; }

        ///<summary>
        /// IsRead
        ///</summary>
        public bool IsRead { get; set; }

        ///<summary>
        /// IsWrite
        ///</summary>
        public bool IsWrite { get; set; }

        ///<summary>
        /// IsExport
        ///</summary>
        public bool IsExport { get; set; }

        ///<summary>
        /// IsImport
        ///</summary>
        public bool IsImport { get; set; }

        ///<summary>
        /// IsReport
        ///</summary>
        public bool IsReport { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Foreign keys
        public virtual Field Field { get; set; } // FK_dbo.FieldPermissions_dbo.Fields_FieldId
        public virtual UserGroupEntity UserGroupEntity { get; set; } // FK_dbo.FieldPermissions_dbo.UserGroupEntities_UserGroupEntityId
    }

}

