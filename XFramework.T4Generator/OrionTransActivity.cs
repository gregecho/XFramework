

namespace XFramework.Models
{

    // OrionTransActivities
    
    public class OrionTransActivity
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Name (length: 128)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// Description (length: 1024)
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// OrionTransPhase
        ///</summary>
        public int OrionTransPhase { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<OrionTransFlowActivity> OrionTransFlowActivities { get; set; } // OrionTransFlowActivities.FK_dbo.OrionTransFlowActivities_dbo.OrionTransActivities_OrionTransActivityId

        public OrionTransActivity()
        {
            OrionTransFlowActivities = new System.Collections.Generic.List<OrionTransFlowActivity>();
        }
    }

}

