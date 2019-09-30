namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MD_tblPaymentDetails
    {
        [Key]
        [Column(Order = 0)]
        public Guid MD_PaymentID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TendPropID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string txtTendPropValue { get; set; }
    }
}
