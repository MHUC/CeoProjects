namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpInvStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpInvStatu()
        {
            lkpInvSubStatus = new HashSet<lkpInvSubStatu>();
            lnkInventories = new HashSet<lnkInventory>();
            lnkNSInventories = new HashSet<lnkNSInventory>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvStatusID { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public bool InStock { get; set; }

        public bool OnOrder { get; set; }

        public bool Transfered { get; set; }

        public bool Sold { get; set; }

        public bool OfficeStatus { get; set; }

        public bool CustStatus { get; set; }

        public bool Active { get; set; }

        public short NSStockFactor { get; set; }

        public bool CanTransfer { get; set; }

        public bool Loss { get; set; }

        public short NSAvailForAssign { get; set; }

        public bool PendOrder { get; set; }

        public bool PendTrans { get; set; }

        public bool QtyFilledStatS { get; set; }

        public bool QtyFilledStatNS { get; set; }

        public short? NSAvailInStock { get; set; }

        public short? NSAvailOnOrder { get; set; }

        public bool AutoRelease { get; set; }

        [Required]
        [StringLength(50)]
        public string InvStatus { get; set; }

        public bool OnOrderPendTrans { get; set; }

        public bool PendOrderPendTrans { get; set; }

        public bool HasOnOrderPOID { get; set; }

        public bool OnOrderAssn { get; set; }

        public bool OnOrderTransfered { get; set; }

        public bool PendOrderTransfered { get; set; }

        public bool CanTransferDeplete { get; set; }

        public bool HasPendingTransferID { get; set; }

        public bool SAvailInStock { get; set; }

        public bool SAvailOnOrder { get; set; }

        public bool LastPurchPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpInvSubStatu> lkpInvSubStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkInventory> lnkInventories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkNSInventory> lnkNSInventories { get; set; }
    }
}
