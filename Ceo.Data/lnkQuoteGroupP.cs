namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkQuoteGroupPS")]
    public partial class lnkQuoteGroupP
    {
        [Key]
        public int LinkID { get; set; }

        public int QuoteGroupID { get; set; }

        public int InventoryID { get; set; }

        public int InventoryType { get; set; }

        public virtual lkpProduct lkpProduct { get; set; }

        public virtual lkpQuoteGroup lkpQuoteGroup { get; set; }

        public virtual lkpService lkpService { get; set; }
    }
}
