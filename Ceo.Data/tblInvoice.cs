namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblInvoice()
        {
            tblChrgAppls = new HashSet<tblChrgAppl>();
            tblDroppedInvoices = new HashSet<tblDroppedInvoice>();
            tblInvoiceProducts = new HashSet<tblInvoiceProduct>();
            lnkQBInvoiceExports = new HashSet<lnkQBInvoiceExport>();
            tblInvoiceServices = new HashSet<tblInvoiceService>();
        }

        [Key]
        public int InvoiceID { get; set; }

        public int CustomerID { get; set; }

        public int OrgInvoiceID { get; set; }

        public int OrganisationID { get; set; }

        public DateTime DateEntered { get; set; }

        public DateTime? DateSent { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public bool ReadyToSend { get; set; }

        public int BillToLocID { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public bool Visible { get; set; }

        public bool Locked { get; set; }

        public bool Posted { get; set; }

        public bool CustomerMerge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChrgAppl> tblChrgAppls { get; set; }

        public virtual tblCustomer tblCustomer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDroppedInvoice> tblDroppedInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInvoiceProduct> tblInvoiceProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkQBInvoiceExport> lnkQBInvoiceExports { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInvoiceService> tblInvoiceServices { get; set; }
    }
}
