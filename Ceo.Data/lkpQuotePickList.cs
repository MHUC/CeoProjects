namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpQuotePickList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpQuotePickList()
        {
            lnkQuotePickListQties = new HashSet<lnkQuotePickListQty>();
            tblCompleteQuoteItems = new HashSet<tblCompleteQuoteItem>();
        }

        [Key]
        public int ListItemID { get; set; }

        public int QuoteItemID { get; set; }

        [Required]
        [StringLength(50)]
        public string DisplayText { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(10)]
        public string Order { get; set; }

        public virtual lkpQuoteItem lkpQuoteItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkQuotePickListQty> lnkQuotePickListQties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompleteQuoteItem> tblCompleteQuoteItems { get; set; }
    }
}
