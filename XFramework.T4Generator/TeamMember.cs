

namespace XFramework.Models
{

    // TeamMembers
    
    public class TeamMember
    {

        ///<summary>
        /// UserId
        ///</summary>
        public int UserId { get; set; }

        ///<summary>
        /// PMID
        ///</summary>
        public int Pmid { get; set; }

        ///<summary>
        /// PM
        ///</summary>
        public int? Pm { get; set; }

        ///<summary>
        /// projectName (length: 1000)
        ///</summary>
        public string ProjectName { get; set; }
    }

}

