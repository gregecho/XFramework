

namespace XFramework.Models
{

    // OrderSamples
    
    public class OrderSample
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// OrderId
        ///</summary>
        public string OrderId { get; set; }

        ///<summary>
        /// OrderName
        ///</summary>
        public string OrderName { get; set; }

        ///<summary>
        /// Comment
        ///</summary>
        public string Comment { get; set; }

        ///<summary>
        /// BusinessUnit
        ///</summary>
        public int BusinessUnit { get; set; }

        ///<summary>
        /// HODate
        ///</summary>
        public System.DateTime? HoDate { get; set; }

        ///<summary>
        /// HBDate
        ///</summary>
        public System.DateTime? HbDate { get; set; }

        ///<summary>
        /// Assets
        ///</summary>
        public int Assets { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

