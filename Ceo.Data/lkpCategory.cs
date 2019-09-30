namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpCategory()
        {
            lkpKits = new HashSet<lkpKit>();
            lnkCategoryAccounts = new HashSet<lnkCategoryAccount>();
            lkpProducts = new HashSet<lkpProduct>();
            lkpServices = new HashSet<lkpService>();
        }

        [Key]
        public int CategoryID { get; set; }

        public int OrganisationID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(1)]
        public string CategoryType { get; set; }

        public bool Active { get; set; }

        public bool IsSkill { get; set; }

        public short ReqMode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpKit> lkpKits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkCategoryAccount> lnkCategoryAccounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpProduct> lkpProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpService> lkpServices { get; set; }
    }
}
