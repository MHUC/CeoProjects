namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpQuoteJobType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpQuoteJobType()
        {
            lnkQuoteJobTypeGroups = new HashSet<lnkQuoteJobTypeGroup>();
            lnkQuoteJobTypeItemOrders = new HashSet<lnkQuoteJobTypeItemOrder>();
            tblCompleteJobTypes = new HashSet<tblCompleteJobType>();
        }

        [Key]
        public int JobTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        public int OrganisationID { get; set; }

        public bool Active { get; set; }

        public int OrigJobTypeID { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkQuoteJobTypeGroup> lnkQuoteJobTypeGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkQuoteJobTypeItemOrder> lnkQuoteJobTypeItemOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompleteJobType> tblCompleteJobTypes { get; set; }
    }
}
