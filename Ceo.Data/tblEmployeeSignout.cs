namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEmployeeSignout")]
    public partial class tblEmployeeSignout
    {
        [Key]
        public int SignoutID { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? DateOut { get; set; }

        public DateTime? DateDueIn { get; set; }

        public DateTime? DateIn { get; set; }

        public bool? MustReturn { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? ReplacementCost { get; set; }

        public bool SignedAgreement { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }
    }
}
