namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrganisation")]
    public partial class tblOrganisation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOrganisation()
        {
            lkpBanks = new HashSet<lkpBank>();
            lkpBillPayers = new HashSet<lkpBillPayer>();
            lkpInventoryReturnCodes = new HashSet<lkpInventoryReturnCode>();
            lkpJobSubStatus = new HashSet<lkpJobSubStatu>();
            lkpQuoteGroups = new HashSet<lkpQuoteGroup>();
            lkpQuoteItems = new HashSet<lkpQuoteItem>();
            lkpQuoteJobTypes = new HashSet<lkpQuoteJobType>();
            lkpSchedEventTypes = new HashSet<lkpSchedEventType>();
            lkpSuppliers = new HashSet<lkpSupplier>();
            lkpTaxCodes = new HashSet<lkpTaxCode>();
            lkpZonePricings = new HashSet<lkpZonePricing>();
            lnkOrgCustPayTypes = new HashSet<lnkOrgCustPayType>();
            tblCompProfiles = new HashSet<tblCompProfile>();
            tblInvTransTickets = new HashSet<tblInvTransTicket>();
            tblLimboes = new HashSet<tblLimbo>();
            tblPOes = new HashSet<tblPO>();
            tblQuotes = new HashSet<tblQuote>();
            tblStockLocations = new HashSet<tblStockLocation>();
            tblTasks = new HashSet<tblTask>();
            tblRegions = new HashSet<tblRegion>();
        }

        [Key]
        public int OrganisationID { get; set; }

        public int? FranchiseID { get; set; }

        public DateTime? DateEntered { get; set; }

        [StringLength(50)]
        public string OrganisationName { get; set; }

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

        [StringLength(50)]
        public string ApplicationName { get; set; }

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

        public bool TrackTravel { get; set; }

        public bool TrackFirstTravel { get; set; }

        public bool TrackLastTravel { get; set; }

        [StringLength(10)]
        public string Latitude { get; set; }

        [StringLength(10)]
        public string Longitude { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpBank> lkpBanks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpBillPayer> lkpBillPayers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpInventoryReturnCode> lkpInventoryReturnCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpJobSubStatu> lkpJobSubStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpQuoteGroup> lkpQuoteGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpQuoteItem> lkpQuoteItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpQuoteJobType> lkpQuoteJobTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpSchedEventType> lkpSchedEventTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpSupplier> lkpSuppliers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpTaxCode> lkpTaxCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpZonePricing> lkpZonePricings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkOrgCustPayType> lnkOrgCustPayTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompProfile> tblCompProfiles { get; set; }

        public virtual tblFranchise tblFranchise { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInvTransTicket> tblInvTransTickets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLimbo> tblLimboes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPO> tblPOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuote> tblQuotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStockLocation> tblStockLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTask> tblTasks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRegion> tblRegions { get; set; }
    }
}
