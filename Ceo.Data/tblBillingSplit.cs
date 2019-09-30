namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBillingSplit")]
    public partial class tblBillingSplit
    {
        [Key]
        [Column(Order = 0)]
        public int BillingSplitID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillingPropID { get; set; }

        public int? BillToCustID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order { get; set; }

        [Key]
        [Column(Order = 3)]
        public double Percent { get; set; }

        public int? DateType { get; set; }

        public int? DateObject { get; set; }

        [Key]
        [Column(Order = 4)]
        public double DateQty { get; set; }

        public int? DateUnits { get; set; }

        [Key]
        [Column(Order = 5)]
        public double DatePctComp { get; set; }

        public int? DateOption { get; set; }

        public int? ServConID { get; set; }

        public int? ServConLineID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ServConCovChrg { get; set; }

        [Key]
        [Column(Order = 6)]
        public double ServConCovQty { get; set; }

        public bool? ServConCovMatch { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimeStamp { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        public int? PaymentTermID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }
    }
}
