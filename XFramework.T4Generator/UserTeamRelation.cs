

namespace XFramework.Models
{

    // UserTeamRelations
    
    public class UserTeamRelation
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// UserTeam_Id
        ///</summary>
        public int UserTeamId { get; set; }

        ///<summary>
        /// User_Id
        ///</summary>
        public int UserId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Foreign keys
        public virtual User User { get; set; } // FK_UserTeamRelations_Users
        public virtual UserTeam UserTeam { get; set; } // FK_UserTeamRelations_UserTeams
    }

}

