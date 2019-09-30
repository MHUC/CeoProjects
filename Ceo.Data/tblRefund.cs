namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRefund")]
    public partial class tblRefund
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRefund()
        {
            lnkTendProps = new HashSet<lnkTendProp>();
            tblRefundItems = new HashSet<tblRefundItem>();
        }

        [Key]
        public int RefundID { get; set; }

        public int CustomerID { get; set; }

        [Required]
        [StringLength(75)]
        public string Description { get; set; }

        public DateTime TransactionDate { get; set; }

        public int RefundMethodID { get; set; }

        public int JobID { get; set; }

        [Required]
        [StringLength(100)]
        public string Notes { get; set; }

        [Column(TypeName = "money")]
        public decimal TaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalAmount { get; set; }

        public bool Recycle { get; set; }

        [Required]
        [StringLength(50)]
        public string Editor { get; set; }

        public DateTime LastEdited { get; set; }

        [Column(TypeName = "money")]
        public decimal CustomerAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal SupplierAmount { get; set; }

        public short CPStatusID { get; set; }

        public DateTime? CPDateTime { get; set; }

        [StringLength(10)]
        public string CPLastCode { get; set; }

        [Column(TypeName = "ntext")]
        public string CPNotes { get; set; }

        public int QBExpID { get; set; }

        [Required]
        [StringLength(36)]
        public string QBTxnID { get; set; }

        public virtual lkpMethodOfPayment lkpMethodOfPayment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkTendProp> lnkTendProps { get; set; }

        public virtual tblJob tblJob { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRefundItem> tblRefundItems { get; set; }
    }
}
