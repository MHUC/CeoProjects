namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkBranchInventory")]
    public partial class lnkBranchInventory
    {
        [Key]
        public int BraInventoryID { get; set; }

        public int? BranchID { get; set; }

        public int? InventoryType { get; set; }

        public int? InventoryID { get; set; }

        [StringLength(255)]
        public string QBCostAcct { get; set; }

        [StringLength(255)]
        public string QBIncomeAcct { get; set; }

        [StringLength(255)]
        public string QBAssetAcct { get; set; }

        [StringLength(255)]
        public string GLCommissionAcct { get; set; }
    }
}
