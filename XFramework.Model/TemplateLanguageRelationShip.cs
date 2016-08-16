

namespace XFramework.Models
{

    // TemplateLanguageRelationShips
    
    public class TemplateLanguageRelationShip
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// TemplateId
        ///</summary>
        public int TemplateId { get; set; }

        ///<summary>
        /// LanguageId
        ///</summary>
        public int LanguageId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

