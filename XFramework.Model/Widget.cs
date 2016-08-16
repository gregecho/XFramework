

namespace XFramework.Models
{

    // Widgets
    
    public class Widget
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// UserId
        ///</summary>
        public int UserId { get; set; }

        ///<summary>
        /// WidgetId
        ///</summary>
        public int WidgetId { get; set; }

        ///<summary>
        /// Sequence
        ///</summary>
        public int Sequence { get; set; }

        ///<summary>
        /// LayoutZoneName (length: 32)
        ///</summary>
        public string LayoutZoneName { get; set; }

        ///<summary>
        /// State (length: 16)
        ///</summary>
        public string State { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// Tabs
        ///</summary>
        public string Tabs { get; set; }

        // Foreign keys
        public virtual User User { get; set; } // FK_dbo.Widgets_dbo.Users_UserId
    }

}

