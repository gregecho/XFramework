

namespace XFramework.Models
{

    // FreewayOrders
    
    public class FreewayOrder
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// ProjectId
        ///</summary>
        public string ProjectId { get; set; }

        ///<summary>
        /// Description
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// Currency
        ///</summary>
        public string Currency { get; set; }

        ///<summary>
        /// TotalPrice
        ///</summary>
        public double TotalPrice { get; set; }

        ///<summary>
        /// Status
        ///</summary>
        public string Status { get; set; }

        ///<summary>
        /// Company
        ///</summary>
        public string Company { get; set; }

        ///<summary>
        /// ProjectOwner
        ///</summary>
        public string ProjectOwner { get; set; }

        ///<summary>
        /// Center
        ///</summary>
        public string Center { get; set; }

        ///<summary>
        /// DateSubmitted
        ///</summary>
        public System.DateTime? DateSubmitted { get; set; }

        ///<summary>
        /// ExpectedStartingDate
        ///</summary>
        public System.DateTime? ExpectedStartingDate { get; set; }

        ///<summary>
        /// ExpectedDeliveryDate
        ///</summary>
        public System.DateTime? ExpectedDeliveryDate { get; set; }

        ///<summary>
        /// SpecialInstructions
        ///</summary>
        public string SpecialInstructions { get; set; }

        ///<summary>
        /// POReference
        ///</summary>
        public string PoReference { get; set; }

        ///<summary>
        /// ProjectManagers
        ///</summary>
        public string ProjectManagers { get; set; }

        ///<summary>
        /// SalesManager
        ///</summary>
        public string SalesManager { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// CredentialName
        ///</summary>
        public string CredentialName { get; set; }

        ///<summary>
        /// IsMapped
        ///</summary>
        public bool IsMapped { get; set; }

        ///<summary>
        /// MappedProjectId
        ///</summary>
        public int? MappedProjectId { get; set; }

        public FreewayOrder()
        {
            IsMapped = false;
        }
    }

}

