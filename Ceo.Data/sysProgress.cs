namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sysProgress")]
    public partial class sysProgress
    {
        [Key]
        public Guid GUID { get; set; }

        public int? TotalRecs { get; set; }

        public int? CurrentRec { get; set; }

        public bool? Cancel { get; set; }

        public DateTime? Created { get; set; }
    }
}
