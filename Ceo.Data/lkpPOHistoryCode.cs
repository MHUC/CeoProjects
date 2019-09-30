namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpPOHistoryCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpPOHistoryCode()
        {
            tblPOHistories = new HashSet<tblPOHistory>();
        }

        [Key]
        public int HistoryCodeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public bool Approved { get; set; }

        public bool Sent { get; set; }

        public bool Received { get; set; }

        public bool Rejected { get; set; }

        public bool Voided { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPOHistory> tblPOHistories { get; set; }
    }
}
