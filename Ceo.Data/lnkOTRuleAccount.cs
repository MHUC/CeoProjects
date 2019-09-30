namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lnkOTRuleAccount
    {
        [Key]
        public int LinkID { get; set; }

        public int OTRuleID { get; set; }

        [StringLength(255)]
        public string GLPayAcct { get; set; }

        public short LocTypeID { get; set; }

        public int LocID { get; set; }

        public virtual lkpOTRule lkpOTRule { get; set; }
    }
}
