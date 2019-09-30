namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkZonePricingPS")]
    public partial class lnkZonePricingP
    {
        [Key]
        public int LinkID { get; set; }

        public int ZonePricingID { get; set; }

        public int InventoryID { get; set; }

        public int InventoryType { get; set; }

        public double? Rate { get; set; }

        public int KitLinkID { get; set; }

        public virtual lkpProduct lkpProduct { get; set; }

        public virtual lkpService lkpService { get; set; }

        public virtual lkpZonePricing lkpZonePricing { get; set; }
    }
}
