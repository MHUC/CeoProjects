namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUserSecurity")]
    public partial class tblUserSecurity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUserSecurity()
        {
            lnkTaskAssigns = new HashSet<lnkTaskAssign>();
            tblInquiries = new HashSet<tblInquiry>();
            tblPayrollAdjs = new HashSet<tblPayrollAdj>();
            tblTimeCards = new HashSet<tblTimeCard>();
            tblUserGroupLinks = new HashSet<tblUserGroupLink>();
            tblWebEvents = new HashSet<tblWebEvent>();
        }

        [Key]
        public int LoginID { get; set; }

        public int OrganisationID { get; set; }

        public int? RegionID { get; set; }

        public int? BranchID { get; set; }

        [Required]
        [StringLength(50)]
        public string LoginName { get; set; }

        [Required]
        [StringLength(40)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public short OrgLevel { get; set; }

        public bool RegionalAdmin { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ExpireDate { get; set; }

        public bool Recycle { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkTaskAssign> lnkTaskAssigns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInquiry> tblInquiries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPayrollAdj> tblPayrollAdjs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTimeCard> tblTimeCards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUserGroupLink> tblUserGroupLinks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWebEvent> tblWebEvents { get; set; }
    }
}
