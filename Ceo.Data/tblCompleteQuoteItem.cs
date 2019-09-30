namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCompleteQuoteItem
    {
        [Key]
        public int CompQuoteItemID { get; set; }

        public int QuoteID { get; set; }

        public int QuoteItemID { get; set; }

        public double Data { get; set; }

        public int DataLink { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public virtual lkpQuoteItem lkpQuoteItem { get; set; }

        public virtual lkpQuotePickList lkpQuotePickList { get; set; }

        public virtual tblQuote tblQuote { get; set; }
    }
}
