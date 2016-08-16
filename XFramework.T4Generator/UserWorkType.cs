

namespace XFramework.Models
{

    // UserWorkTypes
    
    public class UserWorkType
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Name (length: 50)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// Description
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<UserWorkTypeRelation> UserWorkTypeRelations { get; set; } // UserWorkTypeRelations.FK_UserWorkTypeRelations_UserWorkTypes

        public UserWorkType()
        {
            UserWorkTypeRelations = new System.Collections.Generic.List<UserWorkTypeRelation>();
        }
    }

}

