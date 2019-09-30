namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCompleteService")]
    public partial class tblCompleteService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCompleteService()
        {
            tblRefundItems = new HashSet<tblRefundItem>();
        }

        [Key]
        public int CompServID { get; set; }

        public int? JobID { get; set; }

        public int? ServicesID { get; set; }

        public int? ChargeTypeID { get; set; }

        public bool PrintAsFlat { get; set; }

        [Column(TypeName = "money")]
        public decimal? Rate { get; set; }

        public bool AddOn { get; set; }

        public bool Taxable1 { get; set; }

        public bool Commission { get; set; }

        public float CommRateOrig { get; set; }

        public float CommRateAdd { get; set; }

        [Required]
        [StringLength(50)]
        public string Originator { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public short BatchModeID { get; set; }

        public int BatchServID { get; set; }

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

        public int ServConLineID { get; set; }

        public int OSEquipID { get; set; }

        public decimal ServConCovQty { get; set; }

        public int? KitInstID { get; set; }

        public int BillingPropID { get; set; }

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

        public virtual tblBatchJobService tblBatchJobService { get; set; }

        public virtual tblJob tblJob { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRefundItem> tblRefundItems { get; set; }
    }
}
