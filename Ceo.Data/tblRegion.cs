namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRegion")]
    public partial class tblRegion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRegion()
        {
            lkpTaxCodes = new HashSet<lkpTaxCode>();
            lnkRegionProfiles = new HashSet<lnkRegionProfile>();
            tblBranches = new HashSet<tblBranch>();
            tblStockLocations = new HashSet<tblStockLocation>();
            tblTasks = new HashSet<tblTask>();
        }

        [Key]
        public int RegionID { get; set; }

        public int? OrganisationID { get; set; }

        public DateTime? DateEntered { get; set; }

        [StringLength(50)]
        public string RegionName { get; set; }

        [StringLength(30)]
        public string ContactFirstName { get; set; }

        [StringLength(50)]
        public string ContactLastName { get; set; }

        [StringLength(50)]
        public string ContactTitle { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        [StringLength(50)]
        public string Address1 { get; set; }

        [StringLength(50)]
        public string Address2 { get; set; }

        [StringLength(50)]
        public string Address3 { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(20)]
        public string StateOrProvince { get; set; }

        [StringLength(20)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(30)]
        public string PhoneNumber { get; set; }

        [StringLength(30)]
        public string FaxNumber { get; set; }

        [StringLength(60)]
        public string EmailAddress { get; set; }

        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }

        [StringLength(50)]
        public string BankAcct { get; set; }

        [StringLength(50)]
        public string Website { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public bool Active { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string PayAcctID { get; set; }

        [Required]
        [StringLength(75)]
        public string PayContact { get; set; }

        [Required]
        [StringLength(30)]
        public string PayPhone { get; set; }

        [Required]
        [StringLength(60)]
        public string PayEmail { get; set; }

        [Column(TypeName = "ntext")]
        public string PayNotes { get; set; }

        public decimal RoyaltyRate1 { get; set; }

        public decimal RoyaltyRate2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Extra1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Extra2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Extra3 { get; set; }

        [Required]
        [StringLength(50)]
        public string Extra4 { get; set; }

        [Required]
        [StringLength(50)]
        public string Extra5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpTaxCode> lkpTaxCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkRegionProfile> lnkRegionProfiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBranch> tblBranches { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStockLocation> tblStockLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTask> tblTasks { get; set; }
    }
}
