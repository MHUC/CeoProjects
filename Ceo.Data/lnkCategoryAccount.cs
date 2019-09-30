namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lnkCategoryAccount
    {
        [Key]
        public int LinkID { get; set; }

        public int CategoryID { get; set; }

        [StringLength(255)]
        public string QBCostAcct { get; set; }

        [StringLength(255)]
        public string QBIncomeAcct { get; set; }

        [StringLength(255)]
        public string QBAssetAcct { get; set; }

        public short LocTypeID { get; set; }

        public int LocID { get; set; }

        [Required]
        [StringLength(255)]
        public string GLCommissionAcct { get; set; }

        public virtual lkpCategory lkpCategory { get; set; }
    }
}
