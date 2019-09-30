namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEmployeeNote")]
    public partial class tblEmployeeNote
    {
        [Key]
        public int NoteID { get; set; }

        public int BranchID { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? Date { get; set; }

        public int? NoteCodeID { get; set; }

        public short? Rank { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        [StringLength(50)]
        public string Originator { get; set; }

        [StringLength(50)]
        public string Editor { get; set; }

        public DateTime? LastEdited { get; set; }

        public bool Recycle { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public virtual lkpNoteCode lkpNoteCode { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }
    }
}
