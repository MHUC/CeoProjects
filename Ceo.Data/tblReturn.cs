namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblReturn")]
    public partial class tblReturn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblReturn()
        {
            tblRefundItems = new HashSet<tblRefundItem>();
        }

        [Key]
        public int ReturnID { get; set; }

        public int ProductID { get; set; }

        public decimal? Qty { get; set; }

        public DateTime DateEntered { get; set; }

        [Required]
        [StringLength(50)]
        public string Originator { get; set; }

        public int SchedProdID { get; set; }

        public int CompProdID { get; set; }

        public int BatchProdID { get; set; }

        public int ReturnToVendorID { get; set; }

        public int ReturnToStockLocationID { get; set; }

        public int InvAdjustmentID { get; set; }

        public decimal QtyReinstated { get; set; }

        public bool Recycle { get; set; }

        public string ReinstatedInventoryIDs { get; set; }

        [Required]
        [StringLength(100)]
        public string RMANumber { get; set; }

        [Required]
        [StringLength(100)]
        public string ShippingInfo { get; set; }

        [Column(TypeName = "money")]
        public decimal ReturnToVendorRefund { get; set; }

        public virtual lkpProduct lkpProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRefundItem> tblRefundItems { get; set; }
    }
}
