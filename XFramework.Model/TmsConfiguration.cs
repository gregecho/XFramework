

namespace XFramework.Models
{

    // TMSConfigurations
    
    public class TmsConfiguration
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// ProjectId
        ///</summary>
        public int? ProjectId { get; set; }

        ///<summary>
        /// Name (length: 50)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// Description (length: 2000)
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool? IsDeleted { get; set; }
    }

}

