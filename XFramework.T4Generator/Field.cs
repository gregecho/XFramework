

namespace XFramework.Models
{

    // Fields
    
    public class Field
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// TableName (length: 64)
        ///</summary>
        public string TableName { get; set; }

        ///<summary>
        /// Name (length: 32)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<FieldPermission> FieldPermissions { get; set; } // FieldPermissions.FK_dbo.FieldPermissions_dbo.Fields_FieldId

        public Field()
        {
            FieldPermissions = new System.Collections.Generic.List<FieldPermission>();
        }
    }

}

