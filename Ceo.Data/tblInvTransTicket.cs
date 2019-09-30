namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblInvTransTicket")]
    public partial class tblInvTransTicket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblInvTransTicket()
        {
            tblInvTransfers = new HashSet<tblInvTransfer>();
        }

        [Key]
        public int TransTicID { get; set; }

        [Required]
        [StringLength(50)]
        public string AssignedTo { get; set; }

        public bool Completed { get; set; }

        [Required]
        [StringLength(50)]
        public string Originator { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public int OrganisationID { get; set; }

        public DateTime DateEntered { get; set; }

        public DateTime? DateDue { get; set; }

        [StringLength(100)]
        public string Summary { get; set; }

        public int? DefaultStockLocationID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInvTransfer> tblInvTransfers { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }

        public virtual tblStockLocation tblStockLocation { get; set; }
    }
}
