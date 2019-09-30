namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpQBPackage")]
    public partial class lkpQBPackage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpQBPackage()
        {
            tblBranches = new HashSet<tblBranch>();
            tblBranches1 = new HashSet<tblBranch>();
            tblCompProfiles = new HashSet<tblCompProfile>();
        }

        [Key]
        public short QBPackage { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        public bool SupportsPayroll { get; set; }

        public bool Active { get; set; }

        public int Sequence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBranch> tblBranches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBranch> tblBranches1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompProfile> tblCompProfiles { get; set; }
    }
}
