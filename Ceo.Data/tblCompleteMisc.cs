namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCompleteMisc")]
    public partial class tblCompleteMisc
    {
        [Key]
        public int CompMiscID { get; set; }

        public int? JobID { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? Charge { get; set; }

        public bool Taxable { get; set; }

        public double? TaxRate { get; set; }

        public bool Commission { get; set; }

        [Required]
        [StringLength(50)]
        public string Originator { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public virtual tblJob tblJob { get; set; }
    }
}
