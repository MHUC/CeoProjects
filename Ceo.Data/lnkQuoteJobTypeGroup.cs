namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lnkQuoteJobTypeGroup
    {
        [Key]
        public int LinkID { get; set; }

        public int JobTypeID { get; set; }

        public int QuoteGroupID { get; set; }

        public int Order { get; set; }

        public virtual lkpQuoteGroup lkpQuoteGroup { get; set; }

        public virtual lkpQuoteJobType lkpQuoteJobType { get; set; }
    }
}
