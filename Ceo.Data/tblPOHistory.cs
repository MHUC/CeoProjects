namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPOHistory")]
    public partial class tblPOHistory
    {
        [Key]
        public int HistoryID { get; set; }

        public int POID { get; set; }

        public int HistoryCodeID { get; set; }

        public DateTime DateEntered { get; set; }

        [Required]
        [StringLength(50)]
        public string Originator { get; set; }

        public DateTime LastEdited { get; set; }

        [Required]
        [StringLength(50)]
        public string Editor { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public bool Recycle { get; set; }

        public virtual lkpPOHistoryCode lkpPOHistoryCode { get; set; }

        public virtual tblPO tblPO { get; set; }
    }
}
