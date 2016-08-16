

namespace XFramework.Models
{

    // TemplateMappingRules
    
    public class TemplateMappingRule
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Name (length: 500)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// RuleCondtion
        ///</summary>
        public string RuleCondtion { get; set; }

        ///<summary>
        /// Priority
        ///</summary>
        public int Priority { get; set; }

        ///<summary>
        /// OrionTemplateId
        ///</summary>
        public int OrionTemplateId { get; set; }

        ///<summary>
        /// OrionWorkFlowId
        ///</summary>
        public int OrionWorkFlowId { get; set; }

        ///<summary>
        /// FWAccount (length: 128)
        ///</summary>
        public string FwAccount { get; set; }

        ///<summary>
        /// Company (length: 500)
        ///</summary>
        public string Company { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// CredentialId
        ///</summary>
        public int CredentialId { get; set; }

        // Foreign keys
        public virtual IntegrationCredential IntegrationCredential { get; set; } // FK_TemplateMappingRules_Credential
    }

}

