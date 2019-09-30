namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpUnit()
        {
            lkpServices = new HashSet<lkpService>();
            tblServConLines = new HashSet<tblServConLine>();
        }

        [Key]
        public int UnitID { get; set; }

        [StringLength(25)]
        public string Unit { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? OrganisationID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpService> lkpServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblServConLine> tblServConLines { get; set; }
    }
}
