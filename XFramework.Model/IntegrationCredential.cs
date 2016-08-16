

namespace XFramework.Models
{

    // IntegrationCredentials
    
    public class IntegrationCredential
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Key (length: 50)
        ///</summary>
        public string Key { get; set; }

        ///<summary>
        /// Secret (length: 50)
        ///</summary>
        public string Secret { get; set; }

        ///<summary>
        /// CustomerId
        ///</summary>
        public int CustomerId { get; set; }

        ///<summary>
        /// ProgramId
        ///</summary>
        public int ProgramId { get; set; }

        ///<summary>
        /// Description (length: 100)
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// Token (length: 50)
        ///</summary>
        public string Token { get; set; }

        ///<summary>
        /// TokenCreatedTime
        ///</summary>
        public System.DateTime? TokenCreatedTime { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<TemplateMappingRule> TemplateMappingRules { get; set; } // TemplateMappingRules.FK_TemplateMappingRules_Credential

        public IntegrationCredential()
        {
            TemplateMappingRules = new System.Collections.Generic.List<TemplateMappingRule>();
        }
    }

}

