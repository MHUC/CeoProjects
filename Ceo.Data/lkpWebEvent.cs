namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpWebEvent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpWebEvent()
        {
            tblWebEvents = new HashSet<tblWebEvent>();
        }

        [Key]
        public int WebEventID { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public bool Login { get; set; }

        public bool Logout { get; set; }

        public bool FailedLogin { get; set; }

        public bool NoteAdd { get; set; }

        public bool NoteEdit { get; set; }

        public bool NoteDelete { get; set; }

        public bool RequestPass { get; set; }

        public bool CancelJob { get; set; }

        public bool ChangeLocalContact { get; set; }

        public bool ChangeEmail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWebEvent> tblWebEvents { get; set; }
    }
}
