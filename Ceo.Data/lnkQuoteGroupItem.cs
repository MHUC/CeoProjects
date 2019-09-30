namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lnkQuoteGroupItem
    {
        [Key]
        public int LinkID { get; set; }

        public int QuoteGroupID { get; set; }

        public int QuoteItemID { get; set; }

        public double UnitQty { get; set; }

        public double TimeQty { get; set; }

        public virtual lkpQuoteGroup lkpQuoteGroup { get; set; }

        public virtual lkpQuoteItem lkpQuoteItem { get; set; }
    }
}
