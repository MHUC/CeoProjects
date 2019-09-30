namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkQBSupplier")]
    public partial class lnkQBSupplier
    {
        [Key]
        public int LinkID { get; set; }

        public int SupplierID { get; set; }

        public short QBLocTypeID { get; set; }

        public short QBLocID { get; set; }

        public short QBProfileID { get; set; }

        [Required]
        [StringLength(50)]
        public string QBListID { get; set; }

        [Required]
        [StringLength(20)]
        public string QBEditSeq { get; set; }

        public virtual lkpSupplier lkpSupplier { get; set; }
    }
}
