namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkQuoteJobTypeItemOrder")]
    public partial class lnkQuoteJobTypeItemOrder
    {
        [Key]
        public int LinkID { get; set; }

        public int JobTypeID { get; set; }

        public int QuoteItemID { get; set; }

        public int Order { get; set; }

        public virtual lkpQuoteItem lkpQuoteItem { get; set; }

        public virtual lkpQuoteJobType lkpQuoteJobType { get; set; }
    }
}
