namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblBonusRule
    {
        [Key]
        public int BonusRuleID { get; set; }

        [Required]
        [StringLength(80)]
        public string BonusRuleName { get; set; }

        public short OrganisationID { get; set; }

        public int? CustTypeID { get; set; }

        public int? CustSubtypeID { get; set; }

        public short TagType { get; set; }

        public short CalcType { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinRevenue { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinRevenuePct { get; set; }

        [Column(TypeName = "money")]
        public decimal? FlatAmt { get; set; }

        public decimal? FlatAmountPct { get; set; }

        public decimal? Percentage { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime? LastPaidDate { get; set; }

        public bool? Paid { get; set; }

        public DateTime PaidEndDate { get; set; }
    }
}
