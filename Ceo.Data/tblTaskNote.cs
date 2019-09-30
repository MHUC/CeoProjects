namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblTaskNote
    {
        [Key]
        public int TaskNoteID { get; set; }

        public int TaskID { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public bool RTFNote { get; set; }

        [Required]
        [StringLength(50)]
        public string Editor { get; set; }

        public DateTime LastEdited { get; set; }

        public DateTime DateEntered { get; set; }

        public bool System { get; set; }

        public int TaskSchedID { get; set; }

        public virtual tblTask tblTask { get; set; }
    }
}
