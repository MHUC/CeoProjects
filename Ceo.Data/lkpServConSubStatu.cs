namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpServConSubStatu
    {
        [Key]
        public short SubStatusID { get; set; }

        public short StatusID { get; set; }

        public int OrganisationID { get; set; }

        [Required]
        [StringLength(50)]
        public string SubStatusName { get; set; }

        public bool Active { get; set; }

        public bool Default { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
