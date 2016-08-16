

namespace XFramework.Models
{

    // TeamAndUsers
    
    public class TeamAndUser
    {

        ///<summary>
        /// Id
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// UserName (length: 128)
        ///</summary>
        public string UserName { get; set; }

        ///<summary>
        /// Skill
        ///</summary>
        public string Skill { get; set; }

        ///<summary>
        /// WorkType
        ///</summary>
        public string WorkType { get; set; }

        ///<summary>
        /// Type
        ///</summary>
        public int Type { get; set; }
    }

}

