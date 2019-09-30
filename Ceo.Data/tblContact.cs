namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblContact")]
    public partial class tblContact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblContact()
        {
            tblSchedules = new HashSet<tblSchedule>();
        }

        [Key]
        public int ContactID { get; set; }

        public int LocationID { get; set; }

        [StringLength(50)]
        public string ContactName { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public short DisplayOrder { get; set; }

        [StringLength(50)]
        public string Type1 { get; set; }

        [StringLength(10)]
        public string Phone1A { get; set; }

        [StringLength(50)]
        public string Phone1 { get; set; }

        [StringLength(50)]
        public string Type2 { get; set; }

        [StringLength(10)]
        public string Phone2A { get; set; }

        [StringLength(50)]
        public string Phone2 { get; set; }

        [StringLength(50)]
        public string Type3 { get; set; }

        [StringLength(10)]
        public string Phone3A { get; set; }

        [StringLength(50)]
        public string Phone3 { get; set; }

        [StringLength(50)]
        public string Type4 { get; set; }

        [StringLength(10)]
        public string Phone4A { get; set; }

        [StringLength(50)]
        public string Phone4 { get; set; }

        public bool AllowWeb { get; set; }

        [Required]
        [StringLength(15)]
        public string WebPassword { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public virtual tblLocation tblLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchedule> tblSchedules { get; set; }
    }
}
