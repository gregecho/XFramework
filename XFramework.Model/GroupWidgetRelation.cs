

namespace XFramework.Models
{

    // GroupWidgetRelations
    
    public class GroupWidgetRelation
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// GroupId
        ///</summary>
        public int GroupId { get; set; }

        ///<summary>
        /// WidgetId
        ///</summary>
        public int WidgetId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

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
        /// Tabs
        ///</summary>
        public string Tabs { get; set; }

        public GroupWidgetRelation()
        {
            Sequence = 0;
        }
    }

}

