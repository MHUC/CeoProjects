namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblServContract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblServContract()
        {
            tblServConLines = new HashSet<tblServConLine>();
        }

        [Key]
        public int ServConID { get; set; }

        public int CustomerID { get; set; }

        public short StatusID { get; set; }

        public short SubStatusID { get; set; }

        public int? OrgServConID { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public DateTime DateEntered { get; set; }

        public DateTime LastEdited { get; set; }

        [Required]
        [StringLength(50)]
        public string Editor { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalCharge { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalTax1 { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalTax2 { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalTax3 { get; set; }

        public int TaxCodeID1 { get; set; }

        public int TaxCodeID2 { get; set; }

        public int TaxCodeID3 { get; set; }

        public int TaxLocationID { get; set; }

        public decimal TaxPct1 { get; set; }

        public decimal TaxPct2 { get; set; }

        public decimal TaxPct3 { get; set; }

        public int ProfileID { get; set; }

        public bool AutoInvoice { get; set; }

        public int OrganisationID { get; set; }

        public int SalesRepID { get; set; }

        public int BillingPropID { get; set; }

        public string Extra1 { get; set; }

        public string Extra2 { get; set; }

        public string Extra3 { get; set; }

        public string Extra4 { get; set; }

        public string Extra5 { get; set; }

        public string Extra6 { get; set; }

        public string Extra7 { get; set; }

        public string Extra8 { get; set; }

        public string Extra9 { get; set; }

        public string Extra10 { get; set; }

        public string Extra11 { get; set; }

        public string Extra12 { get; set; }

        public string Extra13 { get; set; }

        public string Extra14 { get; set; }

        public string Extra15 { get; set; }

        public string Extra16 { get; set; }

        public string Extra17 { get; set; }

        public string Extra18 { get; set; }

        public string Extra19 { get; set; }

        public string Extra20 { get; set; }

        public string Extra21 { get; set; }

        public string Extra22 { get; set; }

        public string Extra23 { get; set; }

        public string Extra24 { get; set; }

        public string Extra25 { get; set; }

        public virtual tblLocation tblLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblServConLine> tblServConLines { get; set; }
    }
}
