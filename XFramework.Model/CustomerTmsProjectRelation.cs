

namespace XFramework.Models
{

    // CustomerTMSProjectRelations
    
    public class CustomerTmsProjectRelation
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// CustomerId
        ///</summary>
        public int? CustomerId { get; set; }

        ///<summary>
        /// TMSProjectId
        ///</summary>
        public int? TmsProjectId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool? IsDeleted { get; set; }
    }

}

