namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpQuoteItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpQuoteItem()
        {
            lkpQuotePickLists = new HashSet<lkpQuotePickList>();
            lnkQuoteGroupItems = new HashSet<lnkQuoteGroupItem>();
            lnkQuoteJobTypeItemOrders = new HashSet<lnkQuoteJobTypeItemOrder>();
            tblCompleteQuoteItems = new HashSet<tblCompleteQuoteItem>();
        }

        [Key]
        public int QuoteItemID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(750)]
        public string Prompt { get; set; }

        public int QuoteItemTypeID { get; set; }

        public bool AllowNote { get; set; }

        [Required]
        [StringLength(200)]
        public string NotePrompt { get; set; }

        public int UserInputID { get; set; }

        public int OrganisationID { get; set; }

        public bool Active { get; set; }

        public int OrigQuoteItemID { get; set; }

        public virtual lkpQuoteItemType lkpQuoteItemType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpQuotePickList> lkpQuotePickLists { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkQuoteGroupItem> lnkQuoteGroupItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkQuoteJobTypeItemOrder> lnkQuoteJobTypeItemOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompleteQuoteItem> tblCompleteQuoteItems { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }
    }
}
