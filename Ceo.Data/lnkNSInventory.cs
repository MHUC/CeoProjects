namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkNSInventory")]
    public partial class lnkNSInventory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lnkNSInventory()
        {
            tblInvAvgCosts = new HashSet<tblInvAvgCost>();
        }

        [Key]
        public int RecordID { get; set; }

        public int SupplierItemID { get; set; }

        public int ProductID { get; set; }

        [Required]
        [StringLength(100)]
        public string SupplierPartNo { get; set; }

        [Required]
        [StringLength(500)]
        public string SupplierDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal SellPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        public bool CostTaxable { get; set; }

        public double CostTaxPct { get; set; }

        public DateTime Date { get; set; }

        public int POID { get; set; }

        public int POItemID { get; set; }

        public int CustomerID { get; set; }

        public int LocationID { get; set; }

        public int InvStatusID { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public int BatchProdID { get; set; }

        public int CompProdID { get; set; }

        public int InvProdID { get; set; }

        [Required]
        [StringLength(50)]
        public string Bin { get; set; }

        public int BuildDepID { get; set; }

        public DateTime? BuildDate { get; set; }

        public int SchedProdID { get; set; }

        public int SubStatusID { get; set; }

        public int JobID { get; set; }

        public int BatchJobID { get; set; }

        public int OrigRecordID { get; set; }

        public int? FromTransferID { get; set; }

        public int? ToTransferID { get; set; }

        public decimal Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitMiscDistribCost { get; set; }

        public int? InvAdjustmentID { get; set; }

        public int? StockLocationID { get; set; }

        public virtual lkpBuildDep lkpBuildDep { get; set; }

        public virtual lkpInvStatu lkpInvStatu { get; set; }

        public virtual lkpInvSubStatu lkpInvSubStatu { get; set; }

        public virtual tblInvAdjAcct tblInvAdjAcct { get; set; }

        public virtual tblJob tblJob { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInvAvgCost> tblInvAvgCosts { get; set; }

        public virtual tblStockLocation tblStockLocation { get; set; }
    }
}
