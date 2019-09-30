namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCompProfile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCompProfile()
        {
            lnkBranchProfiles = new HashSet<lnkBranchProfile>();
            lnkRegionProfiles = new HashSet<lnkRegionProfile>();
            tblCustomers = new HashSet<tblCustomer>();
            tblSchedules = new HashSet<tblSchedule>();
            tblTransactions = new HashSet<tblTransaction>();
        }

        [Key]
        public int ProfileID { get; set; }

        public int OrganisationID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public bool UseInfo { get; set; }

        [Required]
        [StringLength(50)]
        public string Address1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Address2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Address3 { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(20)]
        public string StateOrProvince { get; set; }

        [Required]
        [StringLength(20)]
        public string PostalCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        [StringLength(30)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(30)]
        public string FaxNumber { get; set; }

        [Required]
        [StringLength(60)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string Website { get; set; }

        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public bool Active { get; set; }

        [Required]
        [StringLength(255)]
        public string QBFileName { get; set; }

        public short QBPackage { get; set; }

        public bool UseQB { get; set; }

        public int? BillingPropID { get; set; }

        [Required]
        [StringLength(255)]
        public string QBClassName { get; set; }

        public virtual lkpQBPackage lkpQBPackage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkBranchProfile> lnkBranchProfiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkRegionProfile> lnkRegionProfiles { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomer> tblCustomers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchedule> tblSchedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }
    }
}
