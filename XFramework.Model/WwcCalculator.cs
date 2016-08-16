

namespace XFramework.Models
{

    // WWCCalculators
    
    public class WwcCalculator
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Name (length: 40)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// RepetitionsPercentage
        ///</summary>
        public double RepetitionsPercentage { get; set; }

        ///<summary>
        /// F100P
        ///</summary>
        public double F100P { get; set; }

        ///<summary>
        /// F95To99P
        ///</summary>
        public double F95To99P { get; set; }

        ///<summary>
        /// F85To94P
        ///</summary>
        public double F85To94P { get; set; }

        ///<summary>
        /// F75To84P
        ///</summary>
        public double F75To84P { get; set; }

        ///<summary>
        /// F50To74P
        ///</summary>
        public double F50To74P { get; set; }

        ///<summary>
        /// MTMatch
        ///</summary>
        public double MtMatch { get; set; }

        ///<summary>
        /// NoMatch
        ///</summary>
        public double NoMatch { get; set; }

        ///<summary>
        /// ICEMatch
        ///</summary>
        public double IceMatch { get; set; }

        ///<summary>
        /// IsDefault
        ///</summary>
        public bool IsDefault { get; set; }

        ///<summary>
        /// Expression (length: 400)
        ///</summary>
        public string Expression { get; set; }

        ///<summary>
        /// Description (length: 400)
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }
    }

}

