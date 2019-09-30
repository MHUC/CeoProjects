namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpQuoteQtyType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpQuoteQtyType()
        {
            lkpQuoteGroups = new HashSet<lkpQuoteGroup>();
        }

        [Key]
        public int QtyTypeID { get; set; }

        [Required]
        [StringLength(20)]
        public string QtyType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpQuoteGroup> lkpQuoteGroups { get; set; }
    }
}
