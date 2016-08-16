

namespace XFramework.Models
{

    // OrionTransFlowActivities
    
    public class OrionTransFlowActivity
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// OrionTransFlowId
        ///</summary>
        public int OrionTransFlowId { get; set; }

        ///<summary>
        /// OrionTransActivityId
        ///</summary>
        public int OrionTransActivityId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// OrderNo
        ///</summary>
        public int OrderNo { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<OrionTransFlowActivityInstance> OrionTransFlowActivityInstances { get; set; } // OrionTransFlowActivityInstances.FK_dbo.OrionTransFlowActivityInstances_dbo.OrionTransFlowActivities_NextFlowActivity_Id
        public virtual System.Collections.Generic.ICollection<OrionTransFlowActivityUser> OrionTransFlowActivityUsers { get; set; } // OrionTransFlowActivityUsers.FK_dbo.OrionTransFlowActivityUsers_dbo.OrionTransFlowActivities_OrionTransFlowActivity_Id
        public virtual System.Collections.Generic.ICollection<OrionTransFlowInstance> OrionTransFlowInstances { get; set; } // OrionTransFlowInstances.FK_dbo.OrionTransFlowInstances_dbo.OrionTransFlowActivities_CurrentFlowActivity_Id

        // Foreign keys
        public virtual OrionTransActivity OrionTransActivity { get; set; } // FK_dbo.OrionTransFlowActivities_dbo.OrionTransActivities_OrionTransActivityId

        public OrionTransFlowActivity()
        {
            OrderNo = 0;
            OrionTransFlowActivityInstances = new System.Collections.Generic.List<OrionTransFlowActivityInstance>();
            OrionTransFlowActivityUsers = new System.Collections.Generic.List<OrionTransFlowActivityUser>();
            OrionTransFlowInstances = new System.Collections.Generic.List<OrionTransFlowInstance>();
        }
    }

}

