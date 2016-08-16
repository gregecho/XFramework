

namespace XFramework.Models
{

    // UserWorkTypeRelations
    
    public class UserWorkTypeRelation
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// UserWorkTypeId
        ///</summary>
        public int UserWorkTypeId { get; set; }

        ///<summary>
        /// UserId
        ///</summary>
        public int UserId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Foreign keys
        public virtual User User { get; set; } // FK_UserWorkTypeRelations_Users
        public virtual UserWorkType UserWorkType { get; set; } // FK_UserWorkTypeRelations_UserWorkTypes
    }

}

