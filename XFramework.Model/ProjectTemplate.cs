

namespace XFramework.Models
{

    // ProjectTemplates
    
    public class ProjectTemplate
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Name (length: 150)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// CreatedBy
        ///</summary>
        public int? CreatedBy { get; set; }

        ///<summary>
        /// CreatedOn
        ///</summary>
        public System.DateTime? CreatedOn { get; set; }

        ///<summary>
        /// ModifiedDate
        ///</summary>
        public System.DateTime? ModifiedDate { get; set; }

        ///<summary>
        /// ModifiedOn
        ///</summary>
        public int? ModifiedOn { get; set; }

        ///<summary>
        /// ClientId
        ///</summary>
        public int ClientId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// TemplateLevel
        ///</summary>
        public int TemplateLevel { get; set; }

        ///<summary>
        /// Description
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// ParentId
        ///</summary>
        public int? ParentId { get; set; }

        public ProjectTemplate()
        {
            TemplateLevel = 0;
        }
    }

}

