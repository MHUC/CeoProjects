namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpPayCycle")]
    public partial class lkpPayCycle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpPayCycle()
        {
            lkpEmployeeSubTypes = new HashSet<lkpEmployeeSubType>();
        }

        [Key]
        public int PayCycleID { get; set; }

        public int PayPeriodsPerYear { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpEmployeeSubType> lkpEmployeeSubTypes { get; set; }
    }
}
