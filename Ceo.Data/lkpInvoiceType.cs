namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpInvoiceType")]
    public partial class lkpInvoiceType
    {
        [Key]
        public int InvoiceTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
