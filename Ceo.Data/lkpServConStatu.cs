namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpServConStatu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short StatusID { get; set; }

        [Required]
        [StringLength(50)]
        public string StatusName { get; set; }

        public bool ActiveStatus { get; set; }

        public bool Active { get; set; }

        public bool Pending { get; set; }

        public bool Canceled { get; set; }

        public bool Completed { get; set; }

        public bool ValidCoverage { get; set; }

        public bool RevProjView { get; set; }

        public bool RevAct { get; set; }

        public bool UseTrans { get; set; }
    }
}
