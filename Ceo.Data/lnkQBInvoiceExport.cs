namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lnkQBInvoiceExport
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QBExpID { get; set; }

        [StringLength(36)]
        public string QBTxnID { get; set; }

        public virtual tblInvoice tblInvoice { get; set; }

        public virtual tblQBExport tblQBExport { get; set; }
    }
}
