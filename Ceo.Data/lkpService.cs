namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpService()
        {
            tblCommServices = new HashSet<tblCommService>();
            lnkQuoteGroupPS = new HashSet<lnkQuoteGroupP>();
            lnkZonePricingPS = new HashSet<lnkZonePricingP>();
            tblBatchJobServices = new HashSet<tblBatchJobService>();
            tblInvoiceServices = new HashSet<tblInvoiceService>();
            tblSchedServices = new HashSet<tblSchedService>();
        }

        [Key]
        public int ServicesID { get; set; }

        public int? OrganisationID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public int? CategoryID { get; set; }

        public int? ChargeTypeID { get; set; }

        public bool PrintAsFlat { get; set; }

        public int? UnitID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        public bool Commission { get; set; }

        public bool PerEmp { get; set; }

        public bool Taxable1 { get; set; }

        public bool Active { get; set; }

        public float CommRateOrig { get; set; }

        public float CommRateAdd { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public bool Taxable2 { get; set; }

        public bool Taxable3 { get; set; }

        [Column(TypeName = "ntext")]
        public string Explanation { get; set; }

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

        public decimal MinDuration { get; set; }

        public virtual lkpCategory lkpCategory { get; set; }

        public virtual lkpChargeType lkpChargeType { get; set; }

        public virtual tblBranch tblBranch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCommService> tblCommServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkQuoteGroupP> lnkQuoteGroupPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkZonePricingP> lnkZonePricingPS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBatchJobService> tblBatchJobServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInvoiceService> tblInvoiceServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchedService> tblSchedServices { get; set; }

        public virtual lkpUnit lkpUnit { get; set; }
    }
}
