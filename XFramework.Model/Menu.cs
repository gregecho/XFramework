

namespace XFramework.Models
{

    // Menus
    
    public class Menu
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
        /// Module
        ///</summary>
        public int Module { get; set; }

        ///<summary>
        /// Order
        ///</summary>
        public int Order { get; set; }

        ///<summary>
        /// Controller (length: 64)
        ///</summary>
        public string Controller { get; set; }

        ///<summary>
        /// Action (length: 64)
        ///</summary>
        public string Action { get; set; }

        ///<summary>
        /// PageId
        ///</summary>
        public int? PageId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// Params
        ///</summary>
        public string Params { get; set; }
    }

}

