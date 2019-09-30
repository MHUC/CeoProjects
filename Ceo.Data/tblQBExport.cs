namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblQBExport")]
    public partial class tblQBExport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblQBExport()
        {
            tblDeposits = new HashSet<tblDeposit>();
            tblInvAdjAccts = new HashSet<tblInvAdjAcct>();
            lnkQBInvoiceExports = new HashSet<lnkQBInvoiceExport>();
        }

        [Key]
        public int QBExpID { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        public DateTime? DateEntered { get; set; }

        public short? QBExpTypeID { get; set; }

        [Required]
        [StringLength(255)]
        public string QBFileName { get; set; }

        public short QBPackage { get; set; }

        public short QBLocTypeID { get; set; }

        public short QBLocID { get; set; }

        public short QBProfileID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDeposit> tblDeposits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInvAdjAcct> tblInvAdjAccts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkQBInvoiceExport> lnkQBInvoiceExports { get; set; }
    }
}
