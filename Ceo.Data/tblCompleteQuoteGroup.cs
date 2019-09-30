namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCompleteQuoteGroup
    {
        [Key]
        public int CompQuoteGroupID { get; set; }

        public int CompJobTypeID { get; set; }

        public int QuoteGroupID { get; set; }

        public double CompUnits { get; set; }

        [Column(TypeName = "money")]
        public decimal CompRate { get; set; }

        public double AdjUnits { get; set; }

        [Column(TypeName = "money")]
        public decimal AdjRate { get; set; }

        [Column(TypeName = "money")]
        public decimal AdjTotal { get; set; }

        public bool Include { get; set; }

        public bool Taxable1 { get; set; }

        public int ChargeTypeID { get; set; }

        public bool Taxable2 { get; set; }

        public bool Taxable3 { get; set; }

        public double CompMinutes { get; set; }

        public double AdjMinutes { get; set; }

        public virtual lkpQuoteGroup lkpQuoteGroup { get; set; }

        public virtual tblCompleteJobType tblCompleteJobType { get; set; }
    }
}
