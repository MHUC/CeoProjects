namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpQuoteItemType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpQuoteItemType()
        {
            lkpQuoteItems = new HashSet<lkpQuoteItem>();
        }

        [Key]
        public int QuoteItemTypeID { get; set; }

        [Required]
        [StringLength(25)]
        public string QuoteItemType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpQuoteItem> lkpQuoteItems { get; set; }
    }
}
