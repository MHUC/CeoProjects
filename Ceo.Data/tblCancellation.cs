namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCancellation
    {
        [Key]
        public int CancelID { get; set; }

        public int? CustomerID { get; set; }

        public int? ScheduleID { get; set; }

        public int? NoteCode { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        [StringLength(50)]
        public string Editor { get; set; }

        public DateTime? LastEdited { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public virtual tblCustomer tblCustomer { get; set; }
    }
}
