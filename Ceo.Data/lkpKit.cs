namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpKit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpKit()
        {
            lnkKitItems = new HashSet<lnkKitItem>();
            tblKitInstances = new HashSet<tblKitInstance>();
        }

        [Key]
        public int KitID { get; set; }

        [Required]
        [StringLength(50)]
        public string KitNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string KitName { get; set; }

        public int CategoryID { get; set; }

        public bool Active { get; set; }

        public short InvPrintMode { get; set; }

        public short OrganisationID { get; set; }

        public bool LockItems { get; set; }

        [Column(TypeName = "ntext")]
        public string KitDescription { get; set; }

        public virtual lkpCategory lkpCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkKitItem> lnkKitItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKitInstance> tblKitInstances { get; set; }
    }
}
