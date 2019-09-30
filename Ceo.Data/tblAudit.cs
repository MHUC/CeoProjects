namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAudit")]
    public partial class tblAudit
    {
        [Key]
        public int AuditID { get; set; }

        public int OrganisationID { get; set; }

        public int LoginID { get; set; }

        public DateTime AuditDate { get; set; }

        [Required]
        [StringLength(250)]
        public string AuditedObjectTypeName { get; set; }

        public int AuditedObjectID { get; set; }

        [Required]
        [StringLength(250)]
        public string AuditedPropertyName { get; set; }

        [StringLength(250)]
        public string BeforeData { get; set; }

        [StringLength(250)]
        public string AfterData { get; set; }

        [Column(TypeName = "ntext")]
        public string BeforeDataLong { get; set; }

        [StringLength(250)]
        public string ParentObjectTypeName { get; set; }

        public int? ParentObjectID { get; set; }
    }
}
