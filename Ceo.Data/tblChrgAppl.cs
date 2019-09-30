namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChrgAppl")]
    public partial class tblChrgAppl
    {
        [Key]
        public int ChargeID { get; set; }

        public int? JobID { get; set; }

        public int InvoiceID { get; set; }

        public int ParentTypeID { get; set; }

        public int ParentID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Rate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Subtotal { get; set; }

        public decimal? Qty { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public int? GroupID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tax1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tax2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tax3 { get; set; }

        public int? ServConLineID { get; set; }

        public int? StatusID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        [Column(TypeName = "money")]
        public decimal? ServConCovChrg { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? Charge { get; set; }

        public decimal? ServConCovQty { get; set; }

        public virtual tblInvoice tblInvoice { get; set; }
    }
}
