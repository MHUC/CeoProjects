namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpQuoteGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpQuoteGroup()
        {
            lnkQuoteGroupItems = new HashSet<lnkQuoteGroupItem>();
            lnkQuoteGroupPS = new HashSet<lnkQuoteGroupP>();
            lnkQuoteJobTypeGroups = new HashSet<lnkQuoteJobTypeGroup>();
            lnkQuotePickListQties = new HashSet<lnkQuotePickListQty>();
            tblCompleteQuoteGroups = new HashSet<tblCompleteQuoteGroup>();
        }

        [Key]
        public int QuoteGroupID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        public int QtyTypeID { get; set; }

        public int OrganisationID { get; set; }

        public bool Active { get; set; }

        public int OrigQuoteGroupID { get; set; }

        public virtual lkpQuoteQtyType lkpQuoteQtyType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkQuoteGroupItem> lnkQuoteGroupItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkQuoteGroupP> lnkQuoteGroupPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkQuoteJobTypeGroup> lnkQuoteJobTypeGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkQuotePickListQty> lnkQuotePickListQties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompleteQuoteGroup> tblCompleteQuoteGroups { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }
    }
}
