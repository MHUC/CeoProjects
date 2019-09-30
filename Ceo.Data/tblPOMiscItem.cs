namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblPOMiscItem
    {
        [Key]
        [Column(Order = 0)]
        public int POMiscItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int POID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal Cost { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(300)]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Taxable { get; set; }

        [Key]
        [Column(Order = 5)]
        public double TaxPct { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal Tax { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal Qty { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool PrintNotes { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short DistribCostMode { get; set; }

        [StringLength(255)]
        public string QBCostAcct { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool IsShipping { get; set; }

        public virtual tblPO tblPO { get; set; }
    }
}
