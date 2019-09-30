namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSchedule()
        {
            lnkDocs = new HashSet<lnkDoc>();
            lnkDocs1 = new HashSet<lnkDoc>();
            tblBatchJobs = new HashSet<tblBatchJob>();
            tblEmpLossTeams = new HashSet<tblEmpLossTeam>();
            tblEstNotes = new HashSet<tblEstNote>();
            tblJobs = new HashSet<tblJob>();
            tblSchedServices = new HashSet<tblSchedService>();
            tblSchedules1 = new HashSet<tblSchedule>();
            tblWebJobNotes = new HashSet<tblWebJobNote>();
            tblSchedules11 = new HashSet<tblSchedule>();
        }

        [Key]
        public int ScheduleID { get; set; }

        public int? CustomerID { get; set; }

        public int? LocationID { get; set; }

        public int BranchID { get; set; }

        [StringLength(100)]
        public string Subject { get; set; }

        public int? TeamID { get; set; }

        public bool AllDay { get; set; }

        public DateTime? StartDate { get; set; }

        public int? StartTime { get; set; }

        public double? Manhours { get; set; }

        public double? ArriveWindow { get; set; }

        public int? StatusID { get; set; }

        public int SubStatusID { get; set; }

        public bool Confirmed { get; set; }

        public bool Canceled { get; set; }

        public bool ServNoCharge { get; set; }

        public bool ProdNoCharge { get; set; }

        public bool Reminder { get; set; }

        [StringLength(50)]
        public string EventName { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCharge { get; set; }

        public bool Recycle { get; set; }

        public bool Lock { get; set; }

        public bool Recur { get; set; }

        public int? RecOption { get; set; }

        [StringLength(50)]
        public string Daily { get; set; }

        public int? Weekly { get; set; }

        public int? Monthly { get; set; }

        public int? MonthlyNth { get; set; }

        public int? Yearly { get; set; }

        [StringLength(150)]
        public string Custom { get; set; }

        public int? Occur { get; set; }

        public DateTime RecurEndDate { get; set; }

        public bool ReasonNoted { get; set; }

        public int OrigSchedID { get; set; }

        public int? QuoteID { get; set; }

        public int? CompJobTypeID { get; set; }

        [StringLength(50)]
        public string Originator { get; set; }

        public DateTime LastEdited { get; set; }

        public int RedoOfJobID { get; set; }

        public DateTime DateEntered { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public double BudgPayHrs { get; set; }

        [Column(TypeName = "money")]
        public decimal BudgPayCost { get; set; }

        public int ProfileID { get; set; }

        public bool BatchMaster { get; set; }

        public bool BatchChild { get; set; }

        public short BatchDays { get; set; }

        public int BatchJobID { get; set; }

        [Column(TypeName = "money")]
        public decimal BudgProdCost { get; set; }

        [Column(TypeName = "money")]
        public decimal BudgCharge { get; set; }

        [Column(TypeName = "money")]
        public decimal BudgChargeTax { get; set; }

        public int? Duration { get; set; }

        public int EstimateID { get; set; }

        public int OSEquipID { get; set; }

        public bool BatchEquip { get; set; }

        public int ServConID { get; set; }

        public int OSEquipJobID { get; set; }

        [Column(TypeName = "ntext")]
        public string InvoiceNotes { get; set; }

        public bool PickList { get; set; }

        public int? MarketingCode { get; set; }

        [StringLength(255)]
        public string MarketingNotes { get; set; }

        public int BillingPropID { get; set; }

        public int EventTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Editor { get; set; }

        [Column(TypeName = "ntext")]
        public string PrivateNotes { get; set; }

        public int? PriceLevelID { get; set; }

        public string Extra1 { get; set; }

        public string Extra2 { get; set; }

        public string Extra3 { get; set; }

        public string Extra4 { get; set; }

        public string Extra5 { get; set; }

        public string Extra6 { get; set; }

        public string Extra7 { get; set; }

        public string Extra8 { get; set; }

        public string Extra9 { get; set; }

        public string Extra10 { get; set; }

        public string Extra11 { get; set; }

        public string Extra12 { get; set; }

        public string Extra13 { get; set; }

        public string Extra14 { get; set; }

        public string Extra15 { get; set; }

        public string Extra16 { get; set; }

        public string Extra17 { get; set; }

        public string Extra18 { get; set; }

        public string Extra19 { get; set; }

        public string Extra20 { get; set; }

        public string Extra21 { get; set; }

        public string Extra22 { get; set; }

        public string Extra23 { get; set; }

        public string Extra24 { get; set; }

        public string Extra25 { get; set; }

        public int? ContactID { get; set; }

        public int? StockLocationID { get; set; }

        public virtual lkpJobSubStatu lkpJobSubStatu { get; set; }

        public virtual lkpMarketingCode lkpMarketingCode { get; set; }

        public virtual lkpPriceLevel lkpPriceLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkDoc> lnkDocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkDoc> lnkDocs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBatchJob> tblBatchJobs { get; set; }

        public virtual tblBatchJob tblBatchJob { get; set; }

        public virtual tblCompleteJobType tblCompleteJobType { get; set; }

        public virtual tblCompProfile tblCompProfile { get; set; }

        public virtual tblContact tblContact { get; set; }

        public virtual tblCustomer tblCustomer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmpLossTeam> tblEmpLossTeams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEstNote> tblEstNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblJob> tblJobs { get; set; }

        public virtual tblLocation tblLocation { get; set; }

        public virtual tblQuote tblQuote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchedService> tblSchedServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchedule> tblSchedules1 { get; set; }

        public virtual tblSchedule tblSchedule1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWebJobNote> tblWebJobNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchedule> tblSchedules11 { get; set; }

        public virtual tblSchedule tblSchedule2 { get; set; }

        public virtual tblStockLocation tblStockLocation { get; set; }

        public static implicit operator List<object>(tblSchedule v)
        {
            throw new NotImplementedException();
        }
    }
}
