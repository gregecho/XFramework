

namespace XFramework.Models
{

    // CustomerCompanies
    
    public class CustomerCompany
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
        /// CodaCode (length: 50)
        ///</summary>
        public string CodaCode { get; set; }

        ///<summary>
        /// FreewayCompanySharedId
        ///</summary>
        public int FreewayCompanySharedId { get; set; }

        ///<summary>
        /// FreewayIntegrationMode
        ///</summary>
        public int FreewayIntegrationMode { get; set; }

        ///<summary>
        /// CustomerId
        ///</summary>
        public int CustomerId { get; set; }

        ///<summary>
        /// ProgramId
        ///</summary>
        public int ProgramId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Foreign keys
        public virtual ClientAccount Customer { get; set; } // FK_CustomerCompanies_Customer
        public virtual ClientAccount Program { get; set; } // FK_CustomerCompanies_Program
    }

}

