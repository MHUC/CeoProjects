namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblQuote
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblQuote()
        {
            lnkDocs = new HashSet<lnkDoc>();
            tblCompleteJobTypes = new HashSet<tblCompleteJobType>();
            tblCompleteQuoteItems = new HashSet<tblCompleteQuoteItem>();
            tblSchedules = new HashSet<tblSchedule>();
        }

        [Key]
        public int QuoteID { get; set; }

        public int OrgQuoteID { get; set; }

        public int OrganisationID { get; set; }

        public int CustomerID { get; set; }

        public bool Accepted { get; set; }

        public int ZonePricingID { get; set; }

        public int OrigQuoteID { get; set; }

        public double TaxPct1 { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public bool Recycle { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime ExpirationDate { get; set; }

        [StringLength(50)]
        public string Originator { get; set; }

        [Column(TypeName = "ntext")]
        public string CancelNote { get; set; }

        public int CancelNoteCodeID { get; set; }

        public int MaxQuoteStage { get; set; }

        [Required]
        [StringLength(20)]
        public string PostalCode { get; set; }

        public int RegionID { get; set; }

        public int BranchID { get; set; }

        public double TaxPct2 { get; set; }

        public double TaxPct3 { get; set; }

        public int TaxCodeID1 { get; set; }

        public int TaxCodeID2 { get; set; }

        public int TaxCodeID3 { get; set; }

        public int LocationID { get; set; }

        public virtual lkpNoteCode lkpNoteCode { get; set; }

        public virtual lkpZonePricing lkpZonePricing { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkDoc> lnkDocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompleteJobType> tblCompleteJobTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompleteQuoteItem> tblCompleteQuoteItems { get; set; }

        public virtual tblCustomer tblCustomer { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchedule> tblSchedules { get; set; }
    }
}
