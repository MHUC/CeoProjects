namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSkillInstance")]
    public partial class tblSkillInstance
    {
        [Key]
        public int SkillInstID { get; set; }

        public short SkillType { get; set; }

        public int SkillID { get; set; }

        public int? BatchJobID { get; set; }

        public int? ScheduleID { get; set; }

        public int? EmployeeID { get; set; }

        public bool? Removed { get; set; }

        public decimal? Qty { get; set; }
    }
}
