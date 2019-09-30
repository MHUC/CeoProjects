namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblJob
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblJob()
        {
            lnkDocs = new HashSet<lnkDoc>();
            lnkInventories = new HashSet<lnkInventory>();
            lnkNSInventories = new HashSet<lnkNSInventory>();
            tblCompleteMiscs = new HashSet<tblCompleteMisc>();
            tblCompleteProducts = new HashSet<tblCompleteProduct>();
            tblCompleteServices = new HashSet<tblCompleteService>();
            tblEmpLossTeams = new HashSet<tblEmpLossTeam>();
            tblPOes = new HashSet<tblPO>();
            tblPOItemIntents = new HashSet<tblPOItemIntent>();
            tblRefunds = new HashSet<tblRefund>();
            tblTenders = new HashSet<tblTender>();
            tblTransactions = new HashSet<tblTransaction>();
        }

        [Key]
        public int JobID { get; set; }

        public int? ScheduleID { get; set; }

        public DateTime? StartDate { get; set; }

        public int? StartTime { get; set; }

        public double? Manhours { get; set; }

        public int? StatusID { get; set; }

        public int SubStatusID { get; set; }

        public bool Confirmed { get; set; }

        public bool ServNoCharge { get; set; }

        public bool ProdNoCharge { get; set; }

        public bool Reminder { get; set; }

        [StringLength(50)]
        public string Originator { get; set; }

        [Required]
        [StringLength(50)]
        public string Editor { get; set; }

        public DateTime LastEdited { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public double BudgPayHrs { get; set; }

        [Column(TypeName = "money")]
        public decimal BudgPayCost { get; set; }

        [Column(TypeName = "money")]
        public decimal BudgProdCost { get; set; }

        [Column(TypeName = "money")]
        public decimal BudgCharge { get; set; }

        [Column(TypeName = "money")]
        public decimal BudgChargeTax { get; set; }

        public int? Duration { get; set; }

        public int? DurVariance { get; set; }

        public int? StartVariance { get; set; }

        public int OSEquipID { get; set; }

        public bool BatchEquip { get; set; }

        public int ServConID { get; set; }

        public int OSEquipJobID { get; set; }

        public short? ActiveSubStatusID { get; set; }

        public bool PickList { get; set; }

        public int? MarketingCode { get; set; }

        [StringLength(255)]
        public string MarketingNotes { get; set; }

        public int? OrderNum { get; set; }

        public short? WONum { get; set; }

        public int? PriceLevelID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(16)]
        public string JobNumText { get; set; }

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

        public bool CustomerMerge { get; set; }

        public int? StockLocationID { get; set; }

        public virtual lkpJobStatu lkpJobStatu { get; set; }

        public virtual lkpJobSubStatu lkpJobSubStatu { get; set; }

        public virtual lkpMarketingCode lkpMarketingCode { get; set; }

        public virtual lkpPriceLevel lkpPriceLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkDoc> lnkDocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkInventory> lnkInventories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkNSInventory> lnkNSInventories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompleteMisc> tblCompleteMiscs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompleteProduct> tblCompleteProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompleteService> tblCompleteServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmpLossTeam> tblEmpLossTeams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPO> tblPOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPOItemIntent> tblPOItemIntents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRefund> tblRefunds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTender> tblTenders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }

        public virtual tblSchedule tblSchedule { get; set; }

        public virtual tblStockLocation tblStockLocation { get; set; }
    }
}
