

namespace XFramework.Models
{

    // PMSTasks
    
    public class PmsTask
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Volume
        ///</summary>
        public double? Volume { get; set; }

        ///<summary>
        /// Vendor
        ///</summary>
        public int? Vendor { get; set; }

        ///<summary>
        /// HODateVendor
        ///</summary>
        public System.DateTime? HoDateVendor { get; set; }

        ///<summary>
        /// HBDateVendor
        ///</summary>
        public System.DateTime? HbDateVendor { get; set; }

        ///<summary>
        /// HOConfirmed
        ///</summary>
        public int? HoConfirmed { get; set; }

        ///<summary>
        /// PMSOrderId
        ///</summary>
        public int PmsOrderId { get; set; }

        ///<summary>
        /// LanguageId
        ///</summary>
        public int LanguageId { get; set; }

        ///<summary>
        /// CreatedDateTime
        ///</summary>
        public System.DateTime CreatedDateTime { get; set; }

        ///<summary>
        /// CreatedBy
        ///</summary>
        public int CreatedBy { get; set; }

        ///<summary>
        /// ModifiedDate
        ///</summary>
        public System.DateTime? ModifiedDate { get; set; }

        ///<summary>
        /// ModifiedOn
        ///</summary>
        public int? ModifiedOn { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        /// HBDateActual
        ///</summary>
        public System.DateTime? HbDateActual { get; set; }

        ///<summary>
        /// TaskComment
        ///</summary>
        public string TaskComment { get; set; }

        ///<summary>
        /// TaskDeliveryStatus
        ///</summary>
        public int? TaskDeliveryStatus { get; set; }

        ///<summary>
        /// Redelivered
        ///</summary>
        public int? Redelivered { get; set; }

        ///<summary>
        /// WWCCalculId
        ///</summary>
        public int WwcCalculId { get; set; }

        ///<summary>
        /// Repetitions
        ///</summary>
        public double? Repetitions { get; set; }

        ///<summary>
        /// ICEMatch
        ///</summary>
        public double? IceMatch { get; set; }

        ///<summary>
        /// F100P
        ///</summary>
        public double? F100P { get; set; }

        ///<summary>
        /// F95To99P
        ///</summary>
        public double? F95To99P { get; set; }

        ///<summary>
        /// F85To94P
        ///</summary>
        public double? F85To94P { get; set; }

        ///<summary>
        /// F75To84P
        ///</summary>
        public double? F75To84P { get; set; }

        ///<summary>
        /// F50To74P
        ///</summary>
        public double? F50To74P { get; set; }

        ///<summary>
        /// MTMatch
        ///</summary>
        public double? MtMatch { get; set; }

        ///<summary>
        /// NoMatch
        ///</summary>
        public double? NoMatch { get; set; }

        ///<summary>
        /// Transalted
        ///</summary>
        public double? Transalted { get; set; }

        ///<summary>
        /// TotalCount
        ///</summary>
        public double? TotalCount { get; set; }

        ///<summary>
        /// ExtStrCol1
        ///</summary>
        public string ExtStrCol1 { get; set; }

        ///<summary>
        /// ExtStrCol2
        ///</summary>
        public string ExtStrCol2 { get; set; }

        ///<summary>
        /// ExtStrCol3
        ///</summary>
        public string ExtStrCol3 { get; set; }

        ///<summary>
        /// ExtStrCol4
        ///</summary>
        public string ExtStrCol4 { get; set; }

        ///<summary>
        /// ExtStrCol5
        ///</summary>
        public string ExtStrCol5 { get; set; }

        ///<summary>
        /// ExtIntCol1
        ///</summary>
        public int? ExtIntCol1 { get; set; }

        ///<summary>
        /// ExtIntCol2
        ///</summary>
        public int? ExtIntCol2 { get; set; }

        ///<summary>
        /// ExtIntCol3
        ///</summary>
        public int? ExtIntCol3 { get; set; }

        ///<summary>
        /// ExtIntCol4
        ///</summary>
        public int? ExtIntCol4 { get; set; }

        ///<summary>
        /// ExtIntCol5
        ///</summary>
        public int? ExtIntCol5 { get; set; }

        ///<summary>
        /// ExtBitCol1
        ///</summary>
        public bool? ExtBitCol1 { get; set; }

        ///<summary>
        /// ExtBitCol2
        ///</summary>
        public bool? ExtBitCol2 { get; set; }

        ///<summary>
        /// ExtBitCol3
        ///</summary>
        public bool? ExtBitCol3 { get; set; }

        ///<summary>
        /// ExtBitCol4
        ///</summary>
        public bool? ExtBitCol4 { get; set; }

        ///<summary>
        /// ExtBitCol5
        ///</summary>
        public bool? ExtBitCol5 { get; set; }

        ///<summary>
        /// ExtDteCol1
        ///</summary>
        public System.DateTime? ExtDteCol1 { get; set; }

        ///<summary>
        /// ExtDteCol2
        ///</summary>
        public System.DateTime? ExtDteCol2 { get; set; }

        ///<summary>
        /// ExtDteCol3
        ///</summary>
        public System.DateTime? ExtDteCol3 { get; set; }

        ///<summary>
        /// ExtDteCol4
        ///</summary>
        public System.DateTime? ExtDteCol4 { get; set; }

        ///<summary>
        /// ExtDteCol5
        ///</summary>
        public System.DateTime? ExtDteCol5 { get; set; }

        ///<summary>
        /// ExtDecCol1
        ///</summary>
        public decimal? ExtDecCol1 { get; set; }

        ///<summary>
        /// ExtDecCol2
        ///</summary>
        public decimal? ExtDecCol2 { get; set; }

        ///<summary>
        /// ExtDecCol3
        ///</summary>
        public decimal? ExtDecCol3 { get; set; }

        ///<summary>
        /// ExtDecCol4
        ///</summary>
        public decimal? ExtDecCol4 { get; set; }

        ///<summary>
        /// ExtDecCol5
        ///</summary>
        public decimal? ExtDecCol5 { get; set; }

        ///<summary>
        /// TaskId
        ///</summary>
        public int? TaskId { get; set; }

        ///<summary>
        /// SourceType
        ///</summary>
        public int? SourceType { get; set; }

        ///<summary>
        /// JobId
        ///</summary>
        public int? JobId { get; set; }

        ///<summary>
        /// ExtStrCol6
        ///</summary>
        public string ExtStrCol6 { get; set; }

        ///<summary>
        /// ExtStrCol7
        ///</summary>
        public string ExtStrCol7 { get; set; }

        ///<summary>
        /// ExtStrCol8
        ///</summary>
        public string ExtStrCol8 { get; set; }

        ///<summary>
        /// ExtStrCol9
        ///</summary>
        public string ExtStrCol9 { get; set; }

        ///<summary>
        /// ExtStrCol10
        ///</summary>
        public string ExtStrCol10 { get; set; }

        ///<summary>
        /// ExtDteCol6
        ///</summary>
        public System.DateTime? ExtDteCol6 { get; set; }

        ///<summary>
        /// ExtDteCol7
        ///</summary>
        public System.DateTime? ExtDteCol7 { get; set; }

        ///<summary>
        /// ExtDteCol8
        ///</summary>
        public System.DateTime? ExtDteCol8 { get; set; }

        ///<summary>
        /// ExtDteCol9
        ///</summary>
        public System.DateTime? ExtDteCol9 { get; set; }

        ///<summary>
        /// ExtDteCol10
        ///</summary>
        public System.DateTime? ExtDteCol10 { get; set; }

        ///<summary>
        /// ExtIntCol6
        ///</summary>
        public int? ExtIntCol6 { get; set; }

        ///<summary>
        /// ExtIntCol7
        ///</summary>
        public int? ExtIntCol7 { get; set; }

        ///<summary>
        /// ExtIntCol8
        ///</summary>
        public int? ExtIntCol8 { get; set; }

        ///<summary>
        /// ExtIntCol9
        ///</summary>
        public int? ExtIntCol9 { get; set; }

        ///<summary>
        /// ExtIntCol10
        ///</summary>
        public int? ExtIntCol10 { get; set; }

        ///<summary>
        /// ExtBitCol6
        ///</summary>
        public bool? ExtBitCol6 { get; set; }

        ///<summary>
        /// ExtBitCol7
        ///</summary>
        public bool? ExtBitCol7 { get; set; }

        ///<summary>
        /// ExtBitCol8
        ///</summary>
        public bool? ExtBitCol8 { get; set; }

        ///<summary>
        /// ExtBitCol9
        ///</summary>
        public bool? ExtBitCol9 { get; set; }

        ///<summary>
        /// ExtBitCol10
        ///</summary>
        public bool? ExtBitCol10 { get; set; }

        ///<summary>
        /// ExtDecCol6
        ///</summary>
        public decimal? ExtDecCol6 { get; set; }

        ///<summary>
        /// ExtDecCol7
        ///</summary>
        public decimal? ExtDecCol7 { get; set; }

        ///<summary>
        /// ExtDecCol8
        ///</summary>
        public decimal? ExtDecCol8 { get; set; }

        ///<summary>
        /// ExtDecCol9
        ///</summary>
        public decimal? ExtDecCol9 { get; set; }

        ///<summary>
        /// ExtDecCol10
        ///</summary>
        public decimal? ExtDecCol10 { get; set; }

        ///<summary>
        /// TaskStatus
        ///</summary>
        public int? TaskStatus { get; set; }

        ///<summary>
        /// DeliveryFilePath
        ///</summary>
        public string DeliveryFilePath { get; set; }

        ///<summary>
        /// ExtStrCol11
        ///</summary>
        public string ExtStrCol11 { get; set; }

        ///<summary>
        /// ExtStrCol12
        ///</summary>
        public string ExtStrCol12 { get; set; }

        ///<summary>
        /// ExtStrCol13
        ///</summary>
        public string ExtStrCol13 { get; set; }

        ///<summary>
        /// ExtStrCol14
        ///</summary>
        public string ExtStrCol14 { get; set; }

        ///<summary>
        /// ExtStrCol15
        ///</summary>
        public string ExtStrCol15 { get; set; }

        ///<summary>
        /// ExtStrCol16
        ///</summary>
        public string ExtStrCol16 { get; set; }

        ///<summary>
        /// ExtStrCol17
        ///</summary>
        public string ExtStrCol17 { get; set; }

        ///<summary>
        /// ExtStrCol18
        ///</summary>
        public string ExtStrCol18 { get; set; }

        ///<summary>
        /// ExtStrCol19
        ///</summary>
        public string ExtStrCol19 { get; set; }

        ///<summary>
        /// ExtStrCol20
        ///</summary>
        public string ExtStrCol20 { get; set; }

        ///<summary>
        /// TotalWords
        ///</summary>
        public int? TotalWords { get; set; }

        ///<summary>
        /// EffortWords
        ///</summary>
        public int? EffortWords { get; set; }

        ///<summary>
        /// AssigneeFullName
        ///</summary>
        public string AssigneeFullName { get; set; }

        ///<summary>
        /// Status
        ///</summary>
        public int Status { get; set; }

        ///<summary>
        /// TaskName
        ///</summary>
        public string TaskName { get; set; }

        ///<summary>
        /// IsMachineTrans
        ///</summary>
        public bool? IsMachineTrans { get; set; }

        public PmsTask()
        {
            Status = 0;
        }
    }

}

