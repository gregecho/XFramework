

namespace XFramework.Models
{

    // relationTableChecks
    
    public class RelationTableCheck
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// sourceTable (length: 100)
        ///</summary>
        public string SourceTable { get; set; }

        ///<summary>
        /// sourceColumn
        ///</summary>
        public string SourceColumn { get; set; }

        ///<summary>
        /// relationTalbe
        ///</summary>
        public string RelationTalbe { get; set; }

        ///<summary>
        /// relationColumn
        ///</summary>
        public string RelationColumn { get; set; }

        ///<summary>
        /// rtype
        ///</summary>
        public string Rtype { get; set; }

        ///<summary>
        /// meg
        ///</summary>
        public string Meg { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

