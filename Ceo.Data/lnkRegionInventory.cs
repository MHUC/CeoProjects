namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkRegionInventory")]
    public partial class lnkRegionInventory
    {
        [Key]
        public int RegInventoryID { get; set; }

        public int? RegionID { get; set; }

        public int? InventoryType { get; set; }

        public int? InventoryID { get; set; }
    }
}
