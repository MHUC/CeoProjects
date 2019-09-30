namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBatchJobProduct")]
    public partial class tblBatchJobProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBatchJobProduct()
        {
            lnkInventories = new HashSet<lnkInventory>();
            tblCompleteProducts = new HashSet<tblCompleteProduct>();
            tblSchedProds = new HashSet<tblSchedProd>();
        }

        [Key]
        public int BatchProdID { get; set; }

        public int? BatchJobID { get; set; }

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

        public short BatchModeID { get; set; }

        public short InvChargeDispLoc { get; set; }

        public short InvVisitDetail { get; set; }

        public short ShowOnWO { get; set; }

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

        public bool BatchEquip { get; set; }

        public int OSEquipJobID { get; set; }

        public bool EquipCreated { get; set; }

        public int ServConLineID { get; set; }

        public int OSEquipID { get; set; }

        public decimal ServConCovQty { get; set; }

        public int? KitInstID { get; set; }

        public int BillingPropID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] RecTimestamp { get; set; }

        [Column(TypeName = "ntext")]
        public string Explanation { get; set; }

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

        public virtual lkpProduct lkpProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkInventory> lnkInventories { get; set; }

        public virtual tblBatchJob tblBatchJob { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompleteProduct> tblCompleteProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchedProd> tblSchedProds { get; set; }
    }
}
