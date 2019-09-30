namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkInventory")]
    public partial class lnkInventory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lnkInventory()
        {
            tblOSEquips = new HashSet<tblOSEquip>();
            lnkInventory1 = new HashSet<lnkInventory>();
        }

        [Key]
        public int InventoryID { get; set; }

        public int SupplierItemID { get; set; }

        public int ProductID { get; set; }

        [Required]
        [StringLength(100)]
        public string SupplierPartNo { get; set; }

        [StringLength(50)]
        public string SerialNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal SellPrice { get; set; }

        public int InvStatusID { get; set; }

        public DateTime ReceivedOn { get; set; }

        public int POID { get; set; }

        public int OrigInventoryID { get; set; }

        public int POItemID { get; set; }

        [Required]
        [StringLength(500)]
        public string SupplierDescription { get; set; }

        [Required]
        [StringLength(50)]
        public string Bin { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public bool CostTaxable { get; set; }

        public double CostTaxPct { get; set; }

        public int CustomerID { get; set; }

        public int LocationID { get; set; }

        public int BatchProdID { get; set; }

        public int SchedProdID { get; set; }

        public int CompProdID { get; set; }

        public int InvProdID { get; set; }

        public int SubStatusID { get; set; }

        public int JobID { get; set; }

        [Required]
        [StringLength(100)]
        public string Manufac { get; set; }

        [Required]
        [StringLength(30)]
        public string ModelNo { get; set; }

        public bool Warranty { get; set; }

        public short WarrLen { get; set; }

        public short WarrLenUnits { get; set; }

        public short WarrStart { get; set; }

        public int BatchJobID { get; set; }

        public int? FromTransferID { get; set; }

        public int? ToTransferID { get; set; }

        [Column(TypeName = "money")]
        public decimal MiscDistribCost { get; set; }

        [Required]
        [StringLength(50)]
        public string SerialNumberM { get; set; }

        public int? InvAdjustmentID { get; set; }

        public int? StockLocationID { get; set; }

        public virtual lkpInvStatu lkpInvStatu { get; set; }

        public virtual lkpInvSubStatu lkpInvSubStatu { get; set; }

        public virtual lkpProduct lkpProduct { get; set; }

        public virtual tblBatchJobProduct tblBatchJobProduct { get; set; }

        public virtual tblCompleteProduct tblCompleteProduct { get; set; }

        public virtual tblCustomer tblCustomer { get; set; }

        public virtual tblInvAdjAcct tblInvAdjAcct { get; set; }

        public virtual tblInvoiceProduct tblInvoiceProduct { get; set; }

        public virtual tblJob tblJob { get; set; }

        public virtual tblLocation tblLocation { get; set; }

        public virtual tblPOItem tblPOItem { get; set; }

        public virtual tblSchedProd tblSchedProd { get; set; }

        public virtual tblSupplierCatalog tblSupplierCatalog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOSEquip> tblOSEquips { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkInventory> lnkInventory1 { get; set; }

        public virtual lnkInventory lnkInventory2 { get; set; }

        public virtual tblStockLocation tblStockLocation { get; set; }
    }
}
