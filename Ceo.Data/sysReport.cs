namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysReport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysReport()
        {
            lnkDocs = new HashSet<lnkDoc>();
        }

        public int ID { get; set; }

        public short? ViewIndex { get; set; }

        public bool RequireOptions { get; set; }

        public bool Vocabulary { get; set; }

        [StringLength(50)]
        public string Text { get; set; }

        [StringLength(50)]
        public string Report { get; set; }

        public bool Customer { get; set; }

        public bool Employee { get; set; }

        public bool Date { get; set; }

        public bool Team { get; set; }

        public bool Status { get; set; }

        public bool Note { get; set; }

        public bool Marketing { get; set; }

        public bool Style { get; set; }

        public bool PayMethod { get; set; }

        public bool PayAtService { get; set; }

        public bool Company { get; set; }

        public bool Zero { get; set; }

        public bool EmployeeNoteCode { get; set; }

        public bool Address { get; set; }

        public bool TransType { get; set; }

        [StringLength(150)]
        public string StyleID { get; set; }

        public bool Active { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public bool EstNote { get; set; }

        public bool UseCrystal { get; set; }

        [StringLength(750)]
        public string ReportFileSource { get; set; }

        [Column(TypeName = "image")]
        public byte[] ReportBlobSource { get; set; }

        public bool IsForJob { get; set; }

        public bool IsForEstimate { get; set; }

        public bool IsForProject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkDoc> lnkDocs { get; set; }
    }
}
