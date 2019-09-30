namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblBranch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBranch()
        {
            lkpProducts = new HashSet<lkpProduct>();
            lkpServices = new HashSet<lkpService>();
            lkpTaxCodes = new HashSet<lkpTaxCode>();
            lkpZones = new HashSet<lkpZone>();
            lnkBranchProfiles = new HashSet<lnkBranchProfile>();
            tblAdjustments = new HashSet<tblAdjustment>();
            tblTransactions = new HashSet<tblTransaction>();
            tblCustomerNotes = new HashSet<tblCustomerNote>();
            tblEmployees = new HashSet<tblEmployee>();
            tblCapAdjusts = new HashSet<tblCapAdjust>();
            tblStockLocations = new HashSet<tblStockLocation>();
            tblTasks = new HashSet<tblTask>();
            tblTeams = new HashSet<tblTeam>();
            tblTenders = new HashSet<tblTender>();
        }

        [Key]
        public int BranchID { get; set; }

        public int? RegionID { get; set; }

        public DateTime? DateEntered { get; set; }

        [StringLength(50)]
        public string BranchName { get; set; }

        [StringLength(30)]
        public string ContactFirstName { get; set; }

        [StringLength(50)]
        public string ContactLastName { get; set; }

        [StringLength(50)]
        public string ContactTitle { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        [StringLength(50)]
        public string Address1 { get; set; }

        [StringLength(50)]
        public string Address2 { get; set; }

        [StringLength(50)]
        public string Address3 { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(20)]
        public string StateOrProvince { get; set; }

        [StringLength(20)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(30)]
        public string PhoneNumber { get; set; }

        [StringLength(30)]
        public string FaxNumber { get; set; }

        [StringLength(60)]
        public string EmailAddress { get; set; }

        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }

        [StringLength(50)]
        public string BankAcct { get; set; }

        [StringLength(50)]
        public string Website { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public bool Active { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string PayAcctID { get; set; }

        [Required]
        [StringLength(75)]
        public string PayContact { get; set; }

        [Required]
        [StringLength(30)]
        public string PayPhone { get; set; }

        [Required]
        [StringLength(60)]
        public string PayEmail { get; set; }

        [Column(TypeName = "ntext")]
        public string PayNotes { get; set; }

        [Required]
        [StringLength(255)]
        public string QBFileName { get; set; }

        public short QBPackage { get; set; }

        public bool UseQB { get; set; }

        [Required]
        [StringLength(255)]
        public string QBCashAcct { get; set; }

        [Required]
        [StringLength(255)]
        public string QBARAcct { get; set; }

        [Required]
        [StringLength(255)]
        public string QBDefIncomeAcct { get; set; }

        [Required]
        [StringLength(255)]
        public string QBDefInvLossAcct { get; set; }

        [Required]
        [StringLength(255)]
        public string QBTipAcct { get; set; }

        [Required]
        [StringLength(255)]
        public string QBSaleTaxAcct1 { get; set; }

        [Required]
        [StringLength(255)]
        public string QBSaleTaxAcct2 { get; set; }

        [Required]
        [StringLength(255)]
        public string QBSaleTaxAcct3 { get; set; }

        public decimal RoyaltyRate1 { get; set; }

        public decimal RoyaltyRate2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Extra1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Extra2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Extra3 { get; set; }

        [Required]
        [StringLength(50)]
        public string Extra4 { get; set; }

        [Required]
        [StringLength(50)]
        public string Extra5 { get; set; }

        public int BillingPropID { get; set; }

        [Required]
        [StringLength(255)]
        public string QBAssetAcct { get; set; }

        [Required]
        [StringLength(255)]
        public string QBAdjustmentAcct { get; set; }

        [Required]
        [StringLength(255)]
        public string QBMiscAcct { get; set; }

        public bool? TrackTravel { get; set; }

        public bool? TrackFirstTravel { get; set; }

        public bool? TrackLastTravel { get; set; }

        [Required]
        [StringLength(255)]
        public string GLPayAcct { get; set; }

        public bool ExportPayroll { get; set; }

        public bool ExportPayrollToGL { get; set; }

        public short? PayrollPackage { get; set; }

        [Required]
        [StringLength(255)]
        public string PayrollFileName { get; set; }

        [Required]
        [StringLength(255)]
        public string QBClassName { get; set; }

        [Required]
        [StringLength(255)]
        public string QBInvAdjAddAcct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpProduct> lkpProducts { get; set; }

        public virtual lkpQBPackage lkpQBPackage { get; set; }

        public virtual lkpQBPackage lkpQBPackage1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpService> lkpServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpTaxCode> lkpTaxCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpZone> lkpZones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkBranchProfile> lnkBranchProfiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAdjustment> tblAdjustments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomerNote> tblCustomerNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmployee> tblEmployees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCapAdjust> tblCapAdjusts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStockLocation> tblStockLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTask> tblTasks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTeam> tblTeams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTender> tblTenders { get; set; }

        public virtual tblRegion tblRegion { get; set; }
    }
}
