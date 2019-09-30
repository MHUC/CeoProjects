namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpZone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpZone()
        {
            lkpZIPZoneLinks = new HashSet<lkpZIPZoneLink>();
            tblEmployees = new HashSet<tblEmployee>();
            tblTeamZones = new HashSet<tblTeamZone>();
            tblLocations = new HashSet<tblLocation>();
        }

        [Key]
        public int ZoneID { get; set; }

        public int? BranchID { get; set; }

        [StringLength(25)]
        public string Zone { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? ZonePricingID { get; set; }

        public bool Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpZIPZoneLink> lkpZIPZoneLinks { get; set; }

        public virtual lkpZonePricing lkpZonePricing { get; set; }

        public virtual tblBranch tblBranch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmployee> tblEmployees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTeamZone> tblTeamZones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLocation> tblLocations { get; set; }
    }
}
