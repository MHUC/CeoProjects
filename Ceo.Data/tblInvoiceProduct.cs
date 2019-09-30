namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblInvoiceProduct")]
    public partial class tblInvoiceProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblInvoiceProduct()
        {
            lnkInventories = new HashSet<lnkInventory>();
        }

        [Key]
        public int InvProdID { get; set; }

        public int? InvoiceID { get; set; }

        public int? ProductID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        public bool AddOn { get; set; }

        public bool Taxable1 { get; set; }

        public bool Commission { get; set; }

        [StringLength(50)]
        public string Originator { get; set; }

        public float CommRateOrig { get; set; }

        public float CommRateAdd { get; set; }

        public DateTime DateEntered { get; set; }

        public int TaxCodeID1 { get; set; }

        public int TaxCodeID2 { get; set; }

        public bool Taxable2 { get; set; }

        public int TaxCodeID3 { get; set; }

        public bool Taxable3 { get; set; }

        [Column(TypeName = "money")]
        public decimal ServConCovChrg { get; set; }

        public decimal TaxRate1 { get; set; }

        public decimal TaxRate2 { get; set; }

        public decimal TaxRate3 { get; set; }

        public decimal Qty { get; set; }

        public bool ServConCovMatch { get; set; }

        public bool GenEquip { get; set; }

        public bool ReplaceEquip { get; set; }

        public int ServConLineID { get; set; }

        public int OSEquipID { get; set; }

        public decimal ServConCovQty { get; set; }

        public short? CCID1 { get; set; }

        public short? CCID2 { get; set; }

        public short? CCID3 { get; set; }

        public decimal? Concentration { get; set; }

        public int? KitInstID { get; set; }

        [Column(TypeName = "ntext")]
        public string Explanation { get; set; }

        public virtual lkpProduct lkpProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkInventory> lnkInventories { get; set; }

        public virtual tblInvoice tblInvoice { get; set; }
    }
}
