namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpInvoiceStatu
    {
        [Key]
        public int InvoiceStatusID { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
