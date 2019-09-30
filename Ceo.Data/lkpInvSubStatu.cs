namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpInvSubStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpInvSubStatu()
        {
            lnkInventories = new HashSet<lnkInventory>();
            lnkNSInventories = new HashSet<lnkNSInventory>();
        }

        [Key]
        public int SubStatusID { get; set; }

        public int InvStatusID { get; set; }

        public int OrganisationID { get; set; }

        [Required]
        [StringLength(50)]
        public string SubStatusName { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public bool Active { get; set; }

        public bool Default { get; set; }

        public virtual lkpInvStatu lkpInvStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkInventory> lnkInventories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkNSInventory> lnkNSInventories { get; set; }
    }
}
