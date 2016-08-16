

namespace XFramework.Models
{

    // PMSOrders
    
    public class PmsOrder
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// OrderName (length: 1000)
        ///</summary>
        public string OrderName { get; set; }

        ///<summary>
        /// ProdStatus
        ///</summary>
        public int ProdStatus { get; set; }

        ///<summary>
        /// HODate
        ///</summary>
        public System.DateTime HoDate { get; set; }

        ///<summary>
        /// HBDate
        ///</summary>
        public System.DateTime HbDate { get; set; }

        ///<summary>
        /// MSContact
        ///</summary>
        public int? MsContact { get; set; }

        ///<summary>
        /// LIOXContact
        ///</summary>
        public int? LioxContact { get; set; }

        ///<summary>
        /// Product
        ///</summary>
        public int? Product { get; set; }

        ///<summary>
        /// GminiNo (length: 100)
        ///</summary>
        public string GminiNo { get; set; }

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
        /// InvoiceMonth
        ///</summary>
        public string InvoiceMonth { get; set; }

        ///<summary>
        /// CCIO
        ///</summary>
        public int? Ccio { get; set; }

        ///<summary>
        /// GLCode
        ///</summary>
        public int? GlCode { get; set; }

        ///<summary>
        /// Release
        ///</summary>
        public string Release { get; set; }

        ///<summary>
        /// Description
        ///</summary>
        public int? Description { get; set; }

        ///<summary>
        /// Category
        ///</summary>
        public int? Category { get; set; }

        ///<summary>
        /// ProjId
        ///</summary>
        public string ProjId { get; set; }

        ///<summary>
        /// TaskType
        ///</summary>
        public int? TaskType { get; set; }

        ///<summary>
        /// OrderComment
        ///</summary>
        public string OrderComment { get; set; }

        ///<summary>
        /// DeliveryStatus
        ///</summary>
        public int? DeliveryStatus { get; set; }

        ///<summary>
        /// Redelivered
        ///</summary>
        public int? Redelivered { get; set; }

        ///<summary>
        /// OrderTemplateId
        ///</summary>
        public int? OrderTemplateId { get; set; }

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
        /// IsTemplate
        ///</summary>
        public bool IsTemplate { get; set; }

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
        /// Discriminator (length: 128)
        ///</summary>
        public string Discriminator { get; set; }

        ///<summary>
        /// Account
        ///</summary>
        public int? Account { get; set; }

        ///<summary>
        /// JobId
        ///</summary>
        public int? JobId { get; set; }

        ///<summary>
        /// SourceType
        ///</summary>
        public int? SourceType { get; set; }

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
        /// InvoicedStatus
        ///</summary>
        public bool? InvoicedStatus { get; set; }

        ///<summary>
        /// ConfigrationId
        ///</summary>
        public int? ConfigrationId { get; set; }

        ///<summary>
        /// ConfigurationId
        ///</summary>
        public int? ConfigurationId { get; set; }

        ///<summary>
        /// DeliveryDate
        ///</summary>
        public System.DateTime? DeliveryDate { get; set; }

        ///<summary>
        /// IsShowTaskList
        ///</summary>
        public bool IsShowTaskList { get; set; }

        ///<summary>
        /// WorkflowId
        ///</summary>
        public int? WorkflowId { get; set; }

        ///<summary>
        /// ProjectStatus
        ///</summary>
        public int ProjectStatus { get; set; }

        ///<summary>
        /// TokenKey (length: 50)
        ///</summary>
        public string TokenKey { get; set; }

        ///<summary>
        /// SourceLanguage
        ///</summary>
        public int SourceLanguage { get; set; }

        ///<summary>
        /// FwOrderId
        ///</summary>
        public string FwOrderId { get; set; }

        ///<summary>
        /// ParentId
        ///</summary>
        public int? ParentId { get; set; }

        ///<summary>
        /// StrCustomerContact
        ///</summary>
        public string StrCustomerContact { get; set; }

        ///<summary>
        /// Program
        ///</summary>
        public int? Program { get; set; }

        ///<summary>
        /// TMSProjectId
        ///</summary>
        public int? TmsProjectId { get; set; }

        ///<summary>
        /// Family
        ///</summary>
        public string Family { get; set; }

        ///<summary>
        /// Flag
        ///</summary>
        public string Flag { get; set; }

        ///<summary>
        /// ActualStartDate
        ///</summary>
        public System.DateTime? ActualStartDate { get; set; }

        ///<summary>
        /// ActualEndDate
        ///</summary>
        public System.DateTime? ActualEndDate { get; set; }

        ///<summary>
        /// FwOrderStatus
        ///</summary>
        public int? FwOrderStatus { get; set; }

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
        /// Source
        ///</summary>
        public string Source { get; set; }

        ///<summary>
        /// StdStrCol1
        ///</summary>
        public string StdStrCol1 { get; set; }

        ///<summary>
        /// StdStrCol2
        ///</summary>
        public string StdStrCol2 { get; set; }

        ///<summary>
        /// StdStrCol3
        ///</summary>
        public string StdStrCol3 { get; set; }

        ///<summary>
        /// StdStrCol4
        ///</summary>
        public string StdStrCol4 { get; set; }

        ///<summary>
        /// StdStrCol5
        ///</summary>
        public string StdStrCol5 { get; set; }

        ///<summary>
        /// StdStrCol6
        ///</summary>
        public string StdStrCol6 { get; set; }

        ///<summary>
        /// StdStrCol7
        ///</summary>
        public string StdStrCol7 { get; set; }

        ///<summary>
        /// StdStrCol8
        ///</summary>
        public string StdStrCol8 { get; set; }

        ///<summary>
        /// StdStrCol9
        ///</summary>
        public string StdStrCol9 { get; set; }

        ///<summary>
        /// StdStrCol10
        ///</summary>
        public string StdStrCol10 { get; set; }

        ///<summary>
        /// StdStrCol11
        ///</summary>
        public string StdStrCol11 { get; set; }

        ///<summary>
        /// StdStrCol12
        ///</summary>
        public string StdStrCol12 { get; set; }

        ///<summary>
        /// StdStrCol13
        ///</summary>
        public string StdStrCol13 { get; set; }

        ///<summary>
        /// StdStrCol14
        ///</summary>
        public string StdStrCol14 { get; set; }

        ///<summary>
        /// StdStrCol15
        ///</summary>
        public string StdStrCol15 { get; set; }

        ///<summary>
        /// StdStrCol16
        ///</summary>
        public string StdStrCol16 { get; set; }

        ///<summary>
        /// StdStrCol17
        ///</summary>
        public string StdStrCol17 { get; set; }

        ///<summary>
        /// StdStrCol18
        ///</summary>
        public string StdStrCol18 { get; set; }

        ///<summary>
        /// StdStrCol19
        ///</summary>
        public string StdStrCol19 { get; set; }

        ///<summary>
        /// StdStrCol20
        ///</summary>
        public string StdStrCol20 { get; set; }

        ///<summary>
        /// StdIntCol1
        ///</summary>
        public int? StdIntCol1 { get; set; }

        ///<summary>
        /// StdIntCol2
        ///</summary>
        public int? StdIntCol2 { get; set; }

        ///<summary>
        /// StdIntCol3
        ///</summary>
        public int? StdIntCol3 { get; set; }

        ///<summary>
        /// StdIntCol4
        ///</summary>
        public int? StdIntCol4 { get; set; }

        ///<summary>
        /// StdIntCol5
        ///</summary>
        public int? StdIntCol5 { get; set; }

        ///<summary>
        /// StdIntCol6
        ///</summary>
        public int? StdIntCol6 { get; set; }

        ///<summary>
        /// StdIntCol7
        ///</summary>
        public int? StdIntCol7 { get; set; }

        ///<summary>
        /// StdIntCol8
        ///</summary>
        public int? StdIntCol8 { get; set; }

        ///<summary>
        /// StdIntCol9
        ///</summary>
        public int? StdIntCol9 { get; set; }

        ///<summary>
        /// StdIntCol10
        ///</summary>
        public int? StdIntCol10 { get; set; }

        ///<summary>
        /// StdIntCol11
        ///</summary>
        public int? StdIntCol11 { get; set; }

        ///<summary>
        /// StdIntCol12
        ///</summary>
        public int? StdIntCol12 { get; set; }

        ///<summary>
        /// StdIntCol13
        ///</summary>
        public int? StdIntCol13 { get; set; }

        ///<summary>
        /// StdIntCol14
        ///</summary>
        public int? StdIntCol14 { get; set; }

        ///<summary>
        /// StdIntCol15
        ///</summary>
        public int? StdIntCol15 { get; set; }

        ///<summary>
        /// StdIntCol16
        ///</summary>
        public int? StdIntCol16 { get; set; }

        ///<summary>
        /// StdIntCol17
        ///</summary>
        public int? StdIntCol17 { get; set; }

        ///<summary>
        /// StdIntCol18
        ///</summary>
        public int? StdIntCol18 { get; set; }

        ///<summary>
        /// StdIntCol19
        ///</summary>
        public int? StdIntCol19 { get; set; }

        ///<summary>
        /// StdIntCol20
        ///</summary>
        public int? StdIntCol20 { get; set; }

        ///<summary>
        /// StdBitCol1
        ///</summary>
        public bool? StdBitCol1 { get; set; }

        ///<summary>
        /// StdBitCol2
        ///</summary>
        public bool? StdBitCol2 { get; set; }

        ///<summary>
        /// StdBitCol3
        ///</summary>
        public bool? StdBitCol3 { get; set; }

        ///<summary>
        /// StdBitCol4
        ///</summary>
        public bool? StdBitCol4 { get; set; }

        ///<summary>
        /// StdBitCol5
        ///</summary>
        public bool? StdBitCol5 { get; set; }

        ///<summary>
        /// StdBitCol6
        ///</summary>
        public bool? StdBitCol6 { get; set; }

        ///<summary>
        /// StdBitCol7
        ///</summary>
        public bool? StdBitCol7 { get; set; }

        ///<summary>
        /// StdBitCol8
        ///</summary>
        public bool? StdBitCol8 { get; set; }

        ///<summary>
        /// StdBitCol9
        ///</summary>
        public bool? StdBitCol9 { get; set; }

        ///<summary>
        /// StdBitCol10
        ///</summary>
        public bool? StdBitCol10 { get; set; }

        ///<summary>
        /// StdBitCol11
        ///</summary>
        public bool? StdBitCol11 { get; set; }

        ///<summary>
        /// StdBitCol12
        ///</summary>
        public bool? StdBitCol12 { get; set; }

        ///<summary>
        /// StdBitCol13
        ///</summary>
        public bool? StdBitCol13 { get; set; }

        ///<summary>
        /// StdBitCol14
        ///</summary>
        public bool? StdBitCol14 { get; set; }

        ///<summary>
        /// StdBitCol15
        ///</summary>
        public bool? StdBitCol15 { get; set; }

        ///<summary>
        /// StdBitCol16
        ///</summary>
        public bool? StdBitCol16 { get; set; }

        ///<summary>
        /// StdBitCol17
        ///</summary>
        public bool? StdBitCol17 { get; set; }

        ///<summary>
        /// StdBitCol18
        ///</summary>
        public bool? StdBitCol18 { get; set; }

        ///<summary>
        /// StdBitCol19
        ///</summary>
        public bool? StdBitCol19 { get; set; }

        ///<summary>
        /// StdBitCol20
        ///</summary>
        public bool? StdBitCol20 { get; set; }

        ///<summary>
        /// StdDecCol1
        ///</summary>
        public decimal? StdDecCol1 { get; set; }

        ///<summary>
        /// StdDecCol2
        ///</summary>
        public decimal? StdDecCol2 { get; set; }

        ///<summary>
        /// StdDecCol3
        ///</summary>
        public decimal? StdDecCol3 { get; set; }

        ///<summary>
        /// StdDecCol4
        ///</summary>
        public decimal? StdDecCol4 { get; set; }

        ///<summary>
        /// StdDecCol5
        ///</summary>
        public decimal? StdDecCol5 { get; set; }

        ///<summary>
        /// StdDecCol6
        ///</summary>
        public decimal? StdDecCol6 { get; set; }

        ///<summary>
        /// StdDecCol7
        ///</summary>
        public decimal? StdDecCol7 { get; set; }

        ///<summary>
        /// StdDecCol8
        ///</summary>
        public decimal? StdDecCol8 { get; set; }

        ///<summary>
        /// StdDecCol9
        ///</summary>
        public decimal? StdDecCol9 { get; set; }

        ///<summary>
        /// StdDecCol10
        ///</summary>
        public decimal? StdDecCol10 { get; set; }

        ///<summary>
        /// StdDecCol11
        ///</summary>
        public decimal? StdDecCol11 { get; set; }

        ///<summary>
        /// StdDecCol12
        ///</summary>
        public decimal? StdDecCol12 { get; set; }

        ///<summary>
        /// StdDecCol13
        ///</summary>
        public decimal? StdDecCol13 { get; set; }

        ///<summary>
        /// StdDecCol14
        ///</summary>
        public decimal? StdDecCol14 { get; set; }

        ///<summary>
        /// StdDecCol15
        ///</summary>
        public decimal? StdDecCol15 { get; set; }

        ///<summary>
        /// StdDecCol16
        ///</summary>
        public decimal? StdDecCol16 { get; set; }

        ///<summary>
        /// StdDecCol17
        ///</summary>
        public decimal? StdDecCol17 { get; set; }

        ///<summary>
        /// StdDecCol18
        ///</summary>
        public decimal? StdDecCol18 { get; set; }

        ///<summary>
        /// StdDecCol19
        ///</summary>
        public decimal? StdDecCol19 { get; set; }

        ///<summary>
        /// StdDecCol20
        ///</summary>
        public decimal? StdDecCol20 { get; set; }

        ///<summary>
        /// StdDteCol1
        ///</summary>
        public System.DateTime? StdDteCol1 { get; set; }

        ///<summary>
        /// StdDteCol2
        ///</summary>
        public System.DateTime? StdDteCol2 { get; set; }

        ///<summary>
        /// StdDteCol3
        ///</summary>
        public System.DateTime? StdDteCol3 { get; set; }

        ///<summary>
        /// StdDteCol4
        ///</summary>
        public System.DateTime? StdDteCol4 { get; set; }

        ///<summary>
        /// StdDteCol5
        ///</summary>
        public System.DateTime? StdDteCol5 { get; set; }

        ///<summary>
        /// StdDteCol6
        ///</summary>
        public System.DateTime? StdDteCol6 { get; set; }

        ///<summary>
        /// StdDteCol7
        ///</summary>
        public System.DateTime? StdDteCol7 { get; set; }

        ///<summary>
        /// StdDteCol8
        ///</summary>
        public System.DateTime? StdDteCol8 { get; set; }

        ///<summary>
        /// StdDteCol9
        ///</summary>
        public System.DateTime? StdDteCol9 { get; set; }

        ///<summary>
        /// StdDteCol10
        ///</summary>
        public System.DateTime? StdDteCol10 { get; set; }

        ///<summary>
        /// StdDteCol11
        ///</summary>
        public System.DateTime? StdDteCol11 { get; set; }

        ///<summary>
        /// StdDteCol12
        ///</summary>
        public System.DateTime? StdDteCol12 { get; set; }

        ///<summary>
        /// StdDteCol13
        ///</summary>
        public System.DateTime? StdDteCol13 { get; set; }

        ///<summary>
        /// StdDteCol14
        ///</summary>
        public System.DateTime? StdDteCol14 { get; set; }

        ///<summary>
        /// StdDteCol15
        ///</summary>
        public System.DateTime? StdDteCol15 { get; set; }

        ///<summary>
        /// StdDteCol16
        ///</summary>
        public System.DateTime? StdDteCol16 { get; set; }

        ///<summary>
        /// StdDteCol17
        ///</summary>
        public System.DateTime? StdDteCol17 { get; set; }

        ///<summary>
        /// StdDteCol18
        ///</summary>
        public System.DateTime? StdDteCol18 { get; set; }

        ///<summary>
        /// StdDteCol19
        ///</summary>
        public System.DateTime? StdDteCol19 { get; set; }

        ///<summary>
        /// StdDteCol20
        ///</summary>
        public System.DateTime? StdDteCol20 { get; set; }

        ///<summary>
        /// OrderServices
        ///</summary>
        public string OrderServices { get; set; }

        ///<summary>
        /// Company
        ///</summary>
        public string Company { get; set; }

        ///<summary>
        /// CustomerContactEmail
        ///</summary>
        public string CustomerContactEmail { get; set; }

        ///<summary>
        /// OrderStatus
        ///</summary>
        public string OrderStatus { get; set; }

        ///<summary>
        /// SalesValue
        ///</summary>
        public string SalesValue { get; set; }

        ///<summary>
        /// Instruction
        ///</summary>
        public string Instruction { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<WfStepRunLog> WfStepRunLogs { get; set; } // WFStepRunLog.FK_WFStepRunLog_PMSOrders

        public PmsOrder()
        {
            IsTemplate = false;
            Discriminator = "";
            IsShowTaskList = false;
            ProjectStatus = 0;
            SourceLanguage = 0;
            WfStepRunLogs = new System.Collections.Generic.List<WfStepRunLog>();
        }
    }

}

