namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblWebJobNote
    {
        [Key]
        public int WebJobNoteID { get; set; }

        public int ScheduleID { get; set; }

        public int NoteCodeID { get; set; }

        public DateTime DateEntered { get; set; }

        public DateTime LastEdited { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Note { get; set; }

        public bool Opened { get; set; }

        [Required]
        [StringLength(50)]
        public string OpenedBy { get; set; }

        public virtual lkpNoteCode lkpNoteCode { get; set; }

        public virtual tblSchedule tblSchedule { get; set; }
    }
}
