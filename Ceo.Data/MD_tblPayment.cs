namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MD_tblPayment
    {
        [Key]
        [Column(Order = 0)]
        public Guid MD_PaymentID { get; set; }

        public int? TenderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PayMethodID { get; set; }

        [Column(TypeName = "money")]
        public decimal? curPaymentAmt { get; set; }

        [Column(TypeName = "money")]
        public decimal? curTipAmt { get; set; }

        [StringLength(255)]
        public string txtNotes { get; set; }

        public bool? boolFieldAdded { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool boolDeleted { get; set; }
    }
}
