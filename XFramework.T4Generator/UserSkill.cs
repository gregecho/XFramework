

namespace XFramework.Models
{

    // UserSkills
    
    public class UserSkill
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
        public virtual System.Collections.Generic.ICollection<UserSkillRelation> UserSkillRelations { get; set; } // UserSkillRelations.FK_UserSkills_UserSkillRelations

        public UserSkill()
        {
            UserSkillRelations = new System.Collections.Generic.List<UserSkillRelation>();
        }
    }

}

