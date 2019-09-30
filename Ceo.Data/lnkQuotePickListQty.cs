namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkQuotePickListQty")]
    public partial class lnkQuotePickListQty
    {
        [Key]
        public int LinkID { get; set; }

        public int ListItemID { get; set; }

        public int QuoteGroupID { get; set; }

        public double UnitQty { get; set; }

        public double TimeQty { get; set; }

        public virtual lkpQuoteGroup lkpQuoteGroup { get; set; }

        public virtual lkpQuotePickList lkpQuotePickList { get; set; }
    }
}
