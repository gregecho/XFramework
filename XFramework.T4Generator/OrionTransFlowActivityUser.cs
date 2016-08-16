

namespace XFramework.Models
{

    // OrionTransFlowActivityUsers
    
    public class OrionTransFlowActivityUser
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// FlowActivityId
        ///</summary>
        public int FlowActivityId { get; set; }

        ///<summary>
        /// UserId
        ///</summary>
        public int UserId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// OrionTransFlowActivity_Id
        ///</summary>
        public int? OrionTransFlowActivityId { get; set; }

        // Foreign keys
        public virtual OrionTransFlowActivity OrionTransFlowActivity { get; set; } // FK_dbo.OrionTransFlowActivityUsers_dbo.OrionTransFlowActivities_OrionTransFlowActivity_Id
        public virtual User User { get; set; } // FK_dbo.OrionTransFlowActivityUsers_dbo.Users_UserId
    }

}

