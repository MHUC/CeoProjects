namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpTendProp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpTendProp()
        {
            lnkTendProps = new HashSet<lnkTendProp>();
        }

        [Key]
        public int TendPropID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public int DataType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkTendProp> lnkTendProps { get; set; }
    }
}
