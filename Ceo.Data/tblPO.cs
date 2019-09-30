namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPO")]
    public partial class tblPO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPO()
        {
            lnkDocs = new HashSet<lnkDoc>();
            tblPOHistories = new HashSet<tblPOHistory>();
            tblPOItems = new HashSet<tblPOItem>();
            tblPOMiscItems = new HashSet<tblPOMiscItem>();
        }

        [Key]
        public int POID { get; set; }

        public int OrganisationID { get; set; }

        public int OrgPOID { get; set; }

        public int SupplierID { get; set; }

        public DateTime DateEntered { get; set; }

        [Required]
        [StringLength(250)]
        public string PaymentTerms { get; set; }

        public DateTime? ReceivedOn { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? NotificationDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Shipping { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderedBy { get; set; }

        [Column(TypeName = "ntext")]
        public string PrintNotes { get; set; }

        [Column(TypeName = "ntext")]
        public string InternalNotes { get; set; }

        public bool Approved { get; set; }

        public bool Sent { get; set; }

        public bool Received { get; set; }

        public bool Invoiced { get; set; }

        [Required]
        [StringLength(50)]
        public string SupplierInvoiceNo { get; set; }

        public DateTime? SupplierInvoiceDate { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalCharge { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalTax { get; set; }

        public DateTime LastEdited { get; set; }

        [Required]
        [StringLength(50)]
        public string Editor { get; set; }

        public bool Recycle { get; set; }

        public bool SalesTax { get; set; }

        public int OrigPOID { get; set; }

        public bool Void { get; set; }

        public short BackOrderNo { get; set; }

        public int CustomerID { get; set; }

        public int LocationID { get; set; }

        public int JobID { get; set; }

        public int BatchJobID { get; set; }

        public bool DropShip { get; set; }

        public DateTime? ArrivalDate { get; set; }

        public decimal TaxPct { get; set; }

        public short QBLocTypeID { get; set; }

        public short QBLocID { get; set; }

        public short QBProfileID { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalChargeReceived { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalTaxReceived { get; set; }

        [StringLength(100)]
        public string Summary { get; set; }

        [StringLength(50)]
        public string ApprovedBy { get; set; }

        public int? ShipToStockLocationID { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalShippingHandling { get; set; }

        public virtual lkpSupplier lkpSupplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkDoc> lnkDocs { get; set; }

        public virtual tblBatchJob tblBatchJob { get; set; }

        public virtual tblCustomer tblCustomer { get; set; }

        public virtual tblJob tblJob { get; set; }

        public virtual tblLocation tblLocation { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPOHistory> tblPOHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPOItem> tblPOItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPOMiscItem> tblPOMiscItems { get; set; }

        public virtual tblStockLocation tblStockLocation { get; set; }
    }
}
