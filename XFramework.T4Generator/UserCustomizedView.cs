

namespace XFramework.Models
{

    // UserCustomizedViews
    
    public class UserCustomizedView
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Name (length: 50)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// Comment (length: 250)
        ///</summary>
        public string Comment { get; set; }

        ///<summary>
        /// IsDefault
        ///</summary>
        public bool IsDefault { get; set; }

        ///<summary>
        /// CreatedDateTime
        ///</summary>
        public System.DateTime CreatedDateTime { get; set; }

        ///<summary>
        /// CreatedBy
        ///</summary>
        public int CreatedBy { get; set; }

        ///<summary>
        /// ModifiedDate
        ///</summary>
        public System.DateTime? ModifiedDate { get; set; }

        ///<summary>
        /// ModifiedOn
        ///</summary>
        public int? ModifiedOn { get; set; }

        ///<summary>
        /// MenuId
        ///</summary>
        public int MenuId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// AccountId
        ///</summary>
        public int AccountId { get; set; }

        public UserCustomizedView()
        {
            AccountId = 0;
        }
    }

}

