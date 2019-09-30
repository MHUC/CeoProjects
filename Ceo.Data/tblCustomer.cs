namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCustomer()
        {
            lnkDocs = new HashSet<lnkDoc>();
            lnkInventories = new HashSet<lnkInventory>();
            tblAdjustments = new HashSet<tblAdjustment>();
            tblCancellations = new HashSet<tblCancellation>();
            tblCustomerNotes = new HashSet<tblCustomerNote>();
            tblCustomerNotes1 = new HashSet<tblCustomerNote>();
            tblLocations = new HashSet<tblLocation>();
            tblTransactions = new HashSet<tblTransaction>();
            tblDroppedInvoices = new HashSet<tblDroppedInvoice>();
            tblInquiries = new HashSet<tblInquiry>();
            tblInvoices = new HashSet<tblInvoice>();
            tblLimboes = new HashSet<tblLimbo>();
            tblOSEquips = new HashSet<tblOSEquip>();
            tblPOes = new HashSet<tblPO>();
            tblQuotes = new HashSet<tblQuote>();
            tblSchedules = new HashSet<tblSchedule>();
            tblWebEvents = new HashSet<tblWebEvent>();
        }

        [Key]
        public int CustomerID { get; set; }

        public int? BranchID { get; set; }

        public DateTime? DateEntered { get; set; }

        public DateTime? DateTerminated { get; set; }

        public int? CustTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(50)]
        public string Prefix { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Suffix { get; set; }

        [Required]
        [StringLength(50)]
        public string Department { get; set; }

        public int? StatusCode { get; set; }

        public int? MarketingCode { get; set; }

        public int? PayMethodID { get; set; }

        [Required]
        [StringLength(50)]
        public string CCNo { get; set; }

        public int CCCardType { get; set; }

        public DateTime? CCExpirationDate { get; set; }

        [StringLength(50)]
        public string DebitCardNo { get; set; }

        public int DebitCardType { get; set; }

        public DateTime? DebitExpirationDate { get; set; }

        public DateTime? DebitStartDate { get; set; }

        [Required]
        [StringLength(50)]
        public string DebitIssueNo { get; set; }

        [Required]
        [StringLength(50)]
        public string DirectAcctNo { get; set; }

        [Required]
        [StringLength(50)]
        public string DirectAcctHolder { get; set; }

        public int? DirectBankID { get; set; }

        [StringLength(50)]
        public string BarterDesc { get; set; }

        public bool PayAtService { get; set; }

        public bool Invoice { get; set; }

        public bool Statement { get; set; }

        public bool Mailings { get; set; }

        [Column(TypeName = "ntext")]
        public string MainNotes { get; set; }

        [Column(TypeName = "ntext")]
        public string PrivateNotes { get; set; }

        [Required]
        [StringLength(50)]
        public string Originator { get; set; }

        [Required]
        [StringLength(50)]
        public string Editor { get; set; }

        public DateTime? LastEdited { get; set; }

        public bool Recycle { get; set; }

        public bool Archive { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public int ProfileID { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? LastCont_Mail { get; set; }

        public short? CustSubTypeID { get; set; }

        public int? PaymentTermID { get; set; }

        public int BillingPropID { get; set; }

        public bool IsBillPayer { get; set; }

        public DateTime? LastCont_Voice { get; set; }

        public DateTime? LastCont_Email { get; set; }

        public short? ContIntOffSet_Mail { get; set; }

        public short? ContIntOffSet_Voice { get; set; }

        public short? ContIntOffSet_Email { get; set; }

        [StringLength(2)]
        public string ContIntUnits_Mail { get; set; }

        [StringLength(2)]
        public string ContIntUnits_Voice { get; set; }

        [StringLength(2)]
        public string ContIntUnits_Email { get; set; }

        public bool? Callings { get; set; }

        public bool? Emailings { get; set; }

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

        public bool AlertManualEnabled { get; set; }

        [Required]
        public string AlertManualText { get; set; }

        [Required]
        [StringLength(50)]
        public string AlertManualLastSetBy { get; set; }

        public DateTime? AlertManualLastSetOn { get; set; }

        public bool AlertPastDueEnabled { get; set; }

        public bool AlertPastDueTriggered { get; set; }

        public int AlertPastDueDays { get; set; }

        public bool AlertCreditLimitEnabled { get; set; }

        public bool AlertCreditLimitTriggered { get; set; }

        [Column(TypeName = "money")]
        public decimal AlertCreditLimitAmount { get; set; }

        public bool AlertHaltJobCreation { get; set; }

        [Required]
        [StringLength(20)]
        public string CCToken { get; set; }

        public virtual lkpMarketingCode lkpMarketingCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkDoc> lnkDocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkInventory> lnkInventories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAdjustment> tblAdjustments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCancellation> tblCancellations { get; set; }

        public virtual tblCompProfile tblCompProfile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomerNote> tblCustomerNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomerNote> tblCustomerNotes1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLocation> tblLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDroppedInvoice> tblDroppedInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInquiry> tblInquiries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInvoice> tblInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLimbo> tblLimboes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOSEquip> tblOSEquips { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPO> tblPOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuote> tblQuotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchedule> tblSchedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWebEvent> tblWebEvents { get; set; }
    }
}
