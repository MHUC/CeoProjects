namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpPaymentTerm
    {
        [Key]
        [Column(Order = 0)]
        public int PaymentTermID { get; set; }

        [StringLength(50)]
        public string PaymentTerm { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Active { get; set; }

        public int? OrganisationID { get; set; }
    }
}
