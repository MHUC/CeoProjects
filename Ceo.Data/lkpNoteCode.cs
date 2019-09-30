namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpNoteCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpNoteCode()
        {
            tblEstNotes = new HashSet<tblEstNote>();
            tblQuotes = new HashSet<tblQuote>();
            tblWebJobNotes = new HashSet<tblWebJobNote>();
            tblEmployeeNotes = new HashSet<tblEmployeeNote>();
        }

        [Key]
        public int NoteCodeID { get; set; }

        public int? OrganisationID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public short? Rank { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public bool PrintOnWO { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] RecTimestamp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEstNote> tblEstNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuote> tblQuotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWebJobNote> tblWebJobNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmployeeNote> tblEmployeeNotes { get; set; }
    }
}
