namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPaycheckDetail")]
    public partial class tblPaycheckDetail
    {
        [Key]
        public int PaycheckDetailID { get; set; }

        public int PaycheckID { get; set; }

        public short PaycheckDetailTypeID { get; set; }

        public short? TimeCodeID { get; set; }

        public short? PayAdjTypeID { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public decimal? Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? Rate { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public int? OTRuleID { get; set; }

        public virtual lkpOTRule lkpOTRule { get; set; }

        public virtual lkpPayAdjType lkpPayAdjType { get; set; }

        public virtual lkpPaycheckDetailType lkpPaycheckDetailType { get; set; }

        public virtual tblPayCheck tblPayCheck { get; set; }
    }
}
