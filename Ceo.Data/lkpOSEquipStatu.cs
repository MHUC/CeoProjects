namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpOSEquipStatu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short StatusID { get; set; }

        [Required]
        [StringLength(50)]
        public string StatusName { get; set; }

        public bool Active { get; set; }
    }
}
