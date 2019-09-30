namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblInvoiceService")]
    public partial class tblInvoiceService
    {
        [Key]
        public int InvServID { get; set; }

        public int? InvoiceID { get; set; }

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

        [StringLength(50)]
        public string Originator { get; set; }

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

        public int ServConLineID { get; set; }

        public int OSEquipID { get; set; }

        public decimal ServConCovQty { get; set; }

        public int? KitInstID { get; set; }

        [Column(TypeName = "ntext")]
        public string Explanation { get; set; }

        public virtual lkpChargeType lkpChargeType { get; set; }

        public virtual lkpService lkpService { get; set; }

        public virtual tblInvoice tblInvoice { get; set; }
    }
}
