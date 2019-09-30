namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblBillingProp
    {
        [Key]
        [Column(Order = 0)]
        public int BillingPropID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillingModeID { get; set; }

        [Column(TypeName = "money")]
        public decimal? CreditLimit { get; set; }

        public bool? SepInvoice { get; set; }

        public bool? UseSchedule { get; set; }

        public bool? AsIncurred { get; set; }

        public DateTime? RecurStartDate { get; set; }

        public int? RecOption { get; set; }

        [StringLength(50)]
        public string Daily { get; set; }

        public int? Weekly { get; set; }

        public int? Monthly { get; set; }

        public int? MonthlyNth { get; set; }

        public int? Yearly { get; set; }

        [StringLength(150)]
        public string Custom { get; set; }

        public DateTime? RecurEndDate { get; set; }

        public int? Occur { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime DateEntered { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimeStamp { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        public bool? PrebillSchedule { get; set; }
    }
}
