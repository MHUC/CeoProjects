namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblFranchise")]
    public partial class tblFranchise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblFranchise()
        {
            tblOrganisations = new HashSet<tblOrganisation>();
        }

        [Key]
        public int FranchiseID { get; set; }

        public DateTime? DateEntered { get; set; }

        [StringLength(50)]
        public string FranchiseName { get; set; }

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
        public string Extension { get; set; }

        [StringLength(30)]
        public string FaxNumber { get; set; }

        [StringLength(60)]
        public string EmailAddress { get; set; }

        [StringLength(50)]
        public string Website { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrganisation> tblOrganisations { get; set; }
    }
}
