

namespace XFramework.Models
{

    // ClientAccounts
    
    public class ClientAccount
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// AccountName
        ///</summary>
        public string AccountName { get; set; }

        ///<summary>
        /// Description
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// ParentId
        ///</summary>
        public int ParentId { get; set; }

        ///<summary>
        /// FreewayCompanyId
        ///</summary>
        public string FreewayCompanyId { get; set; }

        ///<summary>
        /// FreewayIntegrationMode
        ///</summary>
        public int FreewayIntegrationMode { get; set; }

        ///<summary>
        /// CodaCode
        ///</summary>
        public string CodaCode { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<CustomerCompany> Customer { get; set; } // CustomerCompanies.FK_CustomerCompanies_Customer
        public virtual System.Collections.Generic.ICollection<CustomerCompany> Program { get; set; } // CustomerCompanies.FK_CustomerCompanies_Program
        public virtual System.Collections.Generic.ICollection<OrionMessageConfiguration> OrionMessageConfigurations { get; set; } // OrionMessageConfigurations.FK_dbo.OrionMessageConfigurations_dbo.ClientAccounts_ProgramId

        public ClientAccount()
        {
            ParentId = 0;
            FreewayIntegrationMode = 0;
            Customer = new System.Collections.Generic.List<CustomerCompany>();
            Program = new System.Collections.Generic.List<CustomerCompany>();
            OrionMessageConfigurations = new System.Collections.Generic.List<OrionMessageConfiguration>();
        }
    }

}

