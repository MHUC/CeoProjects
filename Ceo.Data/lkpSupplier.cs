namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpSupplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpSupplier()
        {
            lnkQBSuppliers = new HashSet<lnkQBSupplier>();
            lnkDocs = new HashSet<lnkDoc>();
            tblPOes = new HashSet<tblPO>();
            tblSupplierCatalogs = new HashSet<tblSupplierCatalog>();
        }

        [Key]
        public int SupplierID { get; set; }

        public int OrganisationID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Address1 { get; set; }

        [Required]
        [StringLength(200)]
        public string Address2 { get; set; }

        [Required]
        [StringLength(200)]
        public string Address3 { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [Required]
        [StringLength(100)]
        public string StateOrProvince { get; set; }

        [Required]
        [StringLength(20)]
        public string PostalCode { get; set; }

        [Required]
        [StringLength(50)]
        public string ContactName { get; set; }

        [Required]
        [StringLength(50)]
        public string Type1 { get; set; }

        [Required]
        [StringLength(10)]
        public string Phone1A { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Type2 { get; set; }

        [Required]
        [StringLength(10)]
        public string Phone2A { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(150)]
        public string PayInfo { get; set; }

        [Required]
        [StringLength(250)]
        public string PaymentTerms { get; set; }

        public bool SalesTax { get; set; }

        public double TaxPct { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public bool Active { get; set; }

        public bool Recycle { get; set; }

        public DateTime LastEdited { get; set; }

        [Required]
        [StringLength(50)]
        public string Editor { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        public short LeadDays { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkQBSupplier> lnkQBSuppliers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkDoc> lnkDocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPO> tblPOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSupplierCatalog> tblSupplierCatalogs { get; set; }
    }
}
