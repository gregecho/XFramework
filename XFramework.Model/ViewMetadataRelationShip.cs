

namespace XFramework.Models
{

    // ViewMetadataRelationShips
    
    public class ViewMetadataRelationShip
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// ViewId
        ///</summary>
        public int ViewId { get; set; }

        ///<summary>
        /// MetadataId
        ///</summary>
        public int MetadataId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// SortNumber
        ///</summary>
        public int? SortNumber { get; set; }
    }

}

