namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblDroppedInvoice
    {
        [Key]
        public int DroppedInvoiceID { get; set; }

        public int InvoiceID { get; set; }

        public int CustomerID { get; set; }

        public DateTime DroppedDate { get; set; }

        public DateTime? InvoiceDate { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalCharge { get; set; }

        [Column(TypeName = "money")]
        public decimal Tax { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Description { get; set; }

        public int ServConID { get; set; }

        public virtual tblCustomer tblCustomer { get; set; }

        public virtual tblInvoice tblInvoice { get; set; }
    }
}
