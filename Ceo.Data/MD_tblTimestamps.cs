namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MD_tblTimestamps
    {
        [Key]
        public Guid MD_TimestampID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dtTimeIn { get; set; }

        public short? TimeCodeID { get; set; }

        public short? EmployeeID { get; set; }

        public int? JobID { get; set; }
    }
}
