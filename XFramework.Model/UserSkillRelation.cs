

namespace XFramework.Models
{

    // UserSkillRelations
    
    public class UserSkillRelation
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// UserSkillId
        ///</summary>
        public int UserSkillId { get; set; }

        ///<summary>
        /// UserId
        ///</summary>
        public int UserId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Foreign keys
        public virtual User User { get; set; } // FK_Users_UserSkillRelations
        public virtual UserSkill UserSkill { get; set; } // FK_UserSkills_UserSkillRelations
    }

}

