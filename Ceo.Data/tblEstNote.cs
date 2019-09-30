namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblEstNote
    {
        [Key]
        public int NoteID { get; set; }

        public int EstimateID { get; set; }

        public DateTime Date { get; set; }

        public int NoteCodeID { get; set; }

        public short Rank { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        [Required]
        [StringLength(50)]
        public string Originator { get; set; }

        [Required]
        [StringLength(50)]
        public string Editor { get; set; }

        public DateTime LastEdited { get; set; }

        public bool Recycle { get; set; }

        public bool PrintOnWO { get; set; }

        public virtual lkpNoteCode lkpNoteCode { get; set; }

        public virtual tblSchedule tblSchedule { get; set; }
    }
}
