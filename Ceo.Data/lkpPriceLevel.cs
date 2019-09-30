namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpPriceLevel")]
    public partial class lkpPriceLevel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpPriceLevel()
        {
            tblJobs = new HashSet<tblJob>();
            tblLocations = new HashSet<tblLocation>();
            tblSchedules = new HashSet<tblSchedule>();
        }

        [Key]
        public int PriceLevelID { get; set; }

        public int OrgID { get; set; }

        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        public bool Active { get; set; }

        public decimal ServicePercentMultiplier { get; set; }

        public decimal ProductPercentMultiplier { get; set; }

        public bool ApplyToCost { get; set; }

        public int? CreatedBy { get; set; }

        public int? LastEditedBy { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateLastEdited { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimeStamp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblJob> tblJobs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLocation> tblLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchedule> tblSchedules { get; set; }
    }
}
