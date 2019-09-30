namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpTaxCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpTaxCode()
        {
            tblLocations = new HashSet<tblLocation>();
            tblLocations1 = new HashSet<tblLocation>();
            tblLocations2 = new HashSet<tblLocation>();
        }

        [Key]
        public int TaxCodeID { get; set; }

        public short TaxTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string TaxCode { get; set; }

        public int OrganisationID { get; set; }

        public int RegionID { get; set; }

        public int BranchID { get; set; }

        public double TaxPct { get; set; }

        public bool Active { get; set; }

        [Required]
        [StringLength(50)]
        public string QBSalesTaxVend { get; set; }

        public short QBPackage { get; set; }

        public virtual lkpTaxType lkpTaxType { get; set; }

        public virtual tblBranch tblBranch { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }

        public virtual tblRegion tblRegion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLocation> tblLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLocation> tblLocations1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLocation> tblLocations2 { get; set; }
    }
}
