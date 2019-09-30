namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpZonePricing")]
    public partial class lkpZonePricing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpZonePricing()
        {
            lkpZones = new HashSet<lkpZone>();
            lnkZonePricingPS = new HashSet<lnkZonePricingP>();
            tblQuotes = new HashSet<tblQuote>();
        }

        [Key]
        public int ZonePricingID { get; set; }

        [Required]
        [StringLength(75)]
        public string Name { get; set; }

        public int OrganisationID { get; set; }

        public bool Active { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpZone> lkpZones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkZonePricingP> lnkZonePricingPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuote> tblQuotes { get; set; }
    }
}
