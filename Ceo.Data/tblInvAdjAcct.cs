namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblInvAdjAcct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblInvAdjAcct()
        {
            lnkInventories = new HashSet<lnkInventory>();
            lnkNSInventories = new HashSet<lnkNSInventory>();
        }

        [Key]
        public int InvAdjustmentID { get; set; }

        public int ProductID { get; set; }

        public decimal Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal Value { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        public int QBExpID { get; set; }

        public DateTime DateEntered { get; set; }

        [Required]
        [StringLength(36)]
        public string QBTxnID { get; set; }

        [StringLength(255)]
        public string QBAssetAcct { get; set; }

        [StringLength(255)]
        public string QBIncomeAcct { get; set; }

        public short? QBProfileID { get; set; }

        [Required]
        [StringLength(255)]
        public string QBClassName { get; set; }

        public int? StockLocationID { get; set; }

        public int InventoryReturnCodeID { get; set; }

        public bool PartOfRefundItem { get; set; }

        public virtual lkpProduct lkpProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkInventory> lnkInventories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkNSInventory> lnkNSInventories { get; set; }

        public virtual tblQBExport tblQBExport { get; set; }

        public virtual tblStockLocation tblStockLocation { get; set; }
    }
}
