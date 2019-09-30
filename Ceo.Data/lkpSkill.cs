namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpSkill
    {
        [Key]
        public int SkillID { get; set; }

        public int OrganisationID { get; set; }

        [StringLength(50)]
        public string SkillName { get; set; }

        public bool Active { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public short ReqMode { get; set; }
    }
}
