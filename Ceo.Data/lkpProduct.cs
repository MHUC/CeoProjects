namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpProduct()
        {
            tblCommProducts = new HashSet<tblCommProduct>();
            tblBatchJobProducts = new HashSet<tblBatchJobProduct>();
            lnkInventories = new HashSet<lnkInventory>();
            lnkLocInvLevels = new HashSet<lnkLocInvLevel>();
            lnkQuoteGroupPS = new HashSet<lnkQuoteGroupP>();
            lnkZonePricingPS = new HashSet<lnkZonePricingP>();
            tblInvAdjAccts = new HashSet<tblInvAdjAcct>();
            tblInvAvgCosts = new HashSet<tblInvAvgCost>();
            tblInvoiceProducts = new HashSet<tblInvoiceProduct>();
            tblReturns = new HashSet<tblReturn>();
            tblSupplierCatalogs = new HashSet<tblSupplierCatalog>();
            tblSchedProds = new HashSet<tblSchedProd>();
        }

        [Key]
        public int ProductID { get; set; }

        public int? OrganisationID { get; set; }

        [StringLength(50)]
        public string SerialNumber { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public int? CategoryID { get; set; }

        public bool Taxable1 { get; set; }

        public bool Commission { get; set; }

        public bool PerEmp { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public bool Active { get; set; }

        public float CommRateOrig { get; set; }

        public float CommRateAdd { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public bool Inventory { get; set; }

        public bool Serialized { get; set; }

        public bool Taxable2 { get; set; }

        public bool Taxable3 { get; set; }

        public short NSOrderMode { get; set; }

        public short NSCostMode { get; set; }

        public bool GenEquip { get; set; }

        public short? UnitID { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal SellPrice { get; set; }

        [Column(TypeName = "ntext")]
        public string ProductDescription { get; set; }

        public string Extra1 { get; set; }

        public string Extra2 { get; set; }

        public string Extra3 { get; set; }

        public string Extra4 { get; set; }

        public string Extra5 { get; set; }

        public string Extra6 { get; set; }

        public string Extra7 { get; set; }

        public string Extra8 { get; set; }

        public string Extra9 { get; set; }

        public string Extra10 { get; set; }

        public string Extra11 { get; set; }

        public string Extra12 { get; set; }

        public string Extra13 { get; set; }

        public string Extra14 { get; set; }

        public string Extra15 { get; set; }

        public string Extra16 { get; set; }

        public string Extra17 { get; set; }

        public string Extra18 { get; set; }

        public string Extra19 { get; set; }

        public string Extra20 { get; set; }

        public string Extra21 { get; set; }

        public string Extra22 { get; set; }

        public string Extra23 { get; set; }

        public string Extra24 { get; set; }

        public string Extra25 { get; set; }

        public bool SpecialOrder { get; set; }

        public virtual lkpCategory lkpCategory { get; set; }

        public virtual tblBranch tblBranch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCommProduct> tblCommProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBatchJobProduct> tblBatchJobProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkInventory> lnkInventories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkLocInvLevel> lnkLocInvLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkQuoteGroupP> lnkQuoteGroupPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkZonePricingP> lnkZonePricingPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInvAdjAcct> tblInvAdjAccts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInvAvgCost> tblInvAvgCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInvoiceProduct> tblInvoiceProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReturn> tblReturns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSupplierCatalog> tblSupplierCatalogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchedProd> tblSchedProds { get; set; }
    }
}
