namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkOTRuleAppl")]
    public partial class lnkOTRuleAppl
    {
        [Key]
        public int RecordID { get; set; }

        public int OTRuleID { get; set; }

        public short OTEmpApplyMode { get; set; }

        public short? LocTypeID { get; set; }

        public int? LocID { get; set; }

        public int? ZoneID { get; set; }

        public virtual lkpOTRule lkpOTRule { get; set; }
    }
}
