namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSupplierCatalog")]
    public partial class tblSupplierCatalog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSupplierCatalog()
        {
            lnkInventories = new HashSet<lnkInventory>();
            tblPOItems = new HashSet<tblPOItem>();
        }

        [Key]
        public int SupplierItemID { get; set; }

        public int SupplierID { get; set; }

        [Required]
        [StringLength(100)]
        public string SupplierPartNo { get; set; }

        [Required]
        [StringLength(500)]
        public string SupplierDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitCost { get; set; }

        [Column(TypeName = "money")]
        public decimal SellPrice { get; set; }

        public bool Available { get; set; }

        public int ProductID { get; set; }

        public int PrefOrder { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public bool Taxable { get; set; }

        public double TaxPct { get; set; }

        public double UnitFactor { get; set; }

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

        public short? LeadDays { get; set; }

        public virtual lkpProduct lkpProduct { get; set; }

        public virtual lkpSupplier lkpSupplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkInventory> lnkInventories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPOItem> tblPOItems { get; set; }
    }
}
