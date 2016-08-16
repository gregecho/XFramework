

namespace XFramework.Models
{

    // OrionMessageConfigurations
    
    public class OrionMessageConfiguration
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// MessageCode (length: 40)
        ///</summary>
        public string MessageCode { get; set; }

        ///<summary>
        /// MessageCodeValue
        ///</summary>
        public int MessageCodeValue { get; set; }

        ///<summary>
        /// MessageCodeDisplayName (length: 100)
        ///</summary>
        public string MessageCodeDisplayName { get; set; }

        ///<summary>
        /// MessageFormat
        ///</summary>
        public string MessageFormat { get; set; }

        ///<summary>
        /// State
        ///</summary>
        public bool State { get; set; }

        ///<summary>
        /// ProgramId
        ///</summary>
        public int? ProgramId { get; set; }

        ///<summary>
        /// UserId
        ///</summary>
        public int? UserId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Foreign keys
        public virtual ClientAccount ClientAccount { get; set; } // FK_dbo.OrionMessageConfigurations_dbo.ClientAccounts_ProgramId
        public virtual User User { get; set; } // FK_dbo.OrionMessageConfigurations_dbo.Users_UserId
    }

}

