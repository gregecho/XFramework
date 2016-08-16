

namespace XFramework.Models
{

    // TMSProjects
    
    public class TmsProject
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
        /// Description
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool? IsDeleted { get; set; }
    }

}

