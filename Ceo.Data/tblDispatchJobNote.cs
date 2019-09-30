namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblDispatchJobNote
    {
        [Key]
        public int DispatchNoteID { get; set; }

        public int? JobID { get; set; }

        [StringLength(50)]
        public string Editor { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }
    }
}
