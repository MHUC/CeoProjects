namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lnkPayAdjAccount
    {
        [Key]
        public int LinkID { get; set; }

        public short PayAdjTypeID { get; set; }

        [Required]
        [StringLength(255)]
        public string GLPayAcct { get; set; }

        public short LocTypeID { get; set; }

        public int LocID { get; set; }

        public virtual lkpPayAdjType lkpPayAdjType { get; set; }
    }
}
