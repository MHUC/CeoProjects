namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblKitInstance")]
    public partial class tblKitInstance
    {
        [Key]
        public int KitInstID { get; set; }

        public int KitID { get; set; }

        public int? InvoiceID { get; set; }

        public int? BatchJobID { get; set; }

        public int? ScheduleID { get; set; }

        public int? JobID { get; set; }

        public decimal Qty { get; set; }

        public short InvPrintMode { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] RecTimestamp { get; set; }

        [Column(TypeName = "ntext")]
        public string Explanation { get; set; }

        public virtual lkpKit lkpKit { get; set; }
    }
}
