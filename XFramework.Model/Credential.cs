

namespace XFramework.Models
{

    // Credentials
    
    public class Credential
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// UserId
        ///</summary>
        public int UserId { get; set; }

        ///<summary>
        /// Type
        ///</summary>
        public int Type { get; set; }

        ///<summary>
        /// Name
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// Pwd
        ///</summary>
        public string Pwd { get; set; }

        ///<summary>
        /// Description
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// Tenancy
        ///</summary>
        public string Tenancy { get; set; }
    }

}

