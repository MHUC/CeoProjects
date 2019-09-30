namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpTimeCode
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParentType { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParentID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public bool System { get; set; }

        public short Available { get; set; }

        public bool Paid { get; set; }

        public bool OTAble { get; set; }

        public bool Active { get; set; }

        public int Priority { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TimeCodeID { get; set; }

        public int BarColor { get; set; }

        [Required]
        [StringLength(255)]
        public string GLPayAcct { get; set; }
    }
}
