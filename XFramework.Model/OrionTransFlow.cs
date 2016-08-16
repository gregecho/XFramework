

namespace XFramework.Models
{

    // OrionTransFlows
    
    public class OrionTransFlow
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Name (length: 128)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// ClientId
        ///</summary>
        public int ClientId { get; set; }

        ///<summary>
        /// Status
        ///</summary>
        public int Status { get; set; }

        ///<summary>
        /// CreateDate
        ///</summary>
        public System.DateTime CreateDate { get; set; }

        ///<summary>
        /// CreatorId
        ///</summary>
        public int CreatorId { get; set; }

        ///<summary>
        /// Comment (length: 1024)
        ///</summary>
        public string Comment { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

