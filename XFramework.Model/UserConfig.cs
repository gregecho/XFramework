

namespace XFramework.Models
{

    // UserConfigs
    
    public class UserConfig
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Name
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// Code
        ///</summary>
        public string Code { get; set; }

        ///<summary>
        /// Setting
        ///</summary>
        public string Setting { get; set; }

        ///<summary>
        /// UserId
        ///</summary>
        public int UserId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

