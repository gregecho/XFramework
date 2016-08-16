

namespace XFramework.Models
{

    // UserTeams
    
    public class UserTeam
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

        ///<summary>
        /// OperatorId
        ///</summary>
        public int OperatorId { get; set; }

        ///<summary>
        /// TeamOwner (length: 50)
        ///</summary>
        public string TeamOwner { get; set; }

        ///<summary>
        /// CreateTime
        ///</summary>
        public System.DateTime CreateTime { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<UserTeamRelation> UserTeamRelations { get; set; } // UserTeamRelations.FK_UserTeamRelations_UserTeams

        public UserTeam()
        {
            Description = "0";
            TeamOwner = "";
            CreateTime = System.DateTime.Now;
            UserTeamRelations = new System.Collections.Generic.List<UserTeamRelation>();
        }
    }

}

