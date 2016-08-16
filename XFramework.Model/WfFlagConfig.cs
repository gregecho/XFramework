

namespace XFramework.Models
{

    // WFFlagConfig
    
    public class WfFlagConfig
    {

        ///<summary>
        /// ID (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// FlagType (length: 50)
        ///</summary>
        public string FlagType { get; set; }

        ///<summary>
        /// Priority
        ///</summary>
        public int Priority { get; set; }

        ///<summary>
        /// IconClass (length: 50)
        ///</summary>
        public string IconClass { get; set; }

        ///<summary>
        /// Title (length: 100)
        ///</summary>
        public string Title { get; set; }

        ///<summary>
        /// Color (length: 20)
        ///</summary>
        public string Color { get; set; }

        ///<summary>
        /// ProcessType (length: 10)
        ///</summary>
        public string ProcessType { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// PrioritySequence
        ///</summary>
        public int? PrioritySequence { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<WfFlagLog> WfFlagLogs { get; set; } // WFFlagLog.FK_WFFlagLog_WFFlagConfig

        public WfFlagConfig()
        {
            PrioritySequence = 0;
            WfFlagLogs = new System.Collections.Generic.List<WfFlagLog>();
        }
    }

}

