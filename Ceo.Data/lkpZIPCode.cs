namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpZIPCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpZIPCode()
        {
            lkpZIPZoneLinks = new HashSet<lkpZIPZoneLink>();
        }

        [Key]
        public int ZIPCodeID { get; set; }

        public int OrganisationID { get; set; }

        [StringLength(15)]
        public string ZIPCode { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(25)]
        public string State { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public int? TaxCodeID1 { get; set; }

        public int? TaxCodeID2 { get; set; }

        public int? TaxCodeID3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpZIPZoneLink> lkpZIPZoneLinks { get; set; }
    }
}
