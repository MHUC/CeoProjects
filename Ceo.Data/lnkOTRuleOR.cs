namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkOTRuleOR")]
    public partial class lnkOTRuleOR
    {
        [Key]
        public int RecordID { get; set; }

        public int OTRuleID { get; set; }

        public int? EmployeeID { get; set; }

        public short? SubTypeID { get; set; }

        public decimal? Multiplier { get; set; }

        [Column(TypeName = "money")]
        public decimal? Rate { get; set; }

        public virtual lkpOTRule lkpOTRule { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }
    }
}
