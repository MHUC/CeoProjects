namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblPOItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPOItem()
        {
            lnkInventories = new HashSet<lnkInventory>();
            tblPOItemIntents = new HashSet<tblPOItemIntent>();
        }

        [Key]
        public int POItemID { get; set; }

        public int POID { get; set; }

        public int SupplierItemID { get; set; }

        public double QtyOrdered { get; set; }

        public double QtyReceived { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitCost { get; set; }

        [Required]
        [StringLength(50)]
        public string Units { get; set; }

        [Required]
        [StringLength(100)]
        public string SupplierPartNo { get; set; }

        [Required]
        [StringLength(500)]
        public string SupplierDescription { get; set; }

        public bool Taxable { get; set; }

        [Column(TypeName = "money")]
        public decimal Tax { get; set; }

        public int Order { get; set; }

        public double UnitFactor { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitCostReceived { get; set; }

        [Column(TypeName = "money")]
        public decimal MiscDistribCostTot { get; set; }

        public decimal TaxPct { get; set; }

        [Column(TypeName = "money")]
        public decimal TaxReceived { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkInventory> lnkInventories { get; set; }

        public virtual tblPO tblPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPOItemIntent> tblPOItemIntents { get; set; }

        public virtual tblSupplierCatalog tblSupplierCatalog { get; set; }
    }
}
