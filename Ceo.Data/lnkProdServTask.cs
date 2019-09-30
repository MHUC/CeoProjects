namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lnkProdServTask
    {
        [Key]
        public int LinkID { get; set; }

        public short InventoryType { get; set; }

        public int InventoryID { get; set; }

        public int TaskSchedID { get; set; }
    }
}
