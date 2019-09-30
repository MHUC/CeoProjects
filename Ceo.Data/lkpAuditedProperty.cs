namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpAuditedProperty")]
    public partial class lkpAuditedProperty
    {
        [Key]
        public int AuditablePropertyID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Required]
        [StringLength(128)]
        public string LookupTable { get; set; }

        [Required]
        [StringLength(128)]
        public string LookupKey { get; set; }

        [Required]
        [StringLength(128)]
        public string LookupValue { get; set; }
    }
}
