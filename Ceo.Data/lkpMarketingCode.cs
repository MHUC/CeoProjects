namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpMarketingCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpMarketingCode()
        {
            tblCustomers = new HashSet<tblCustomer>();
            tblJobs = new HashSet<tblJob>();
            tblSchedules = new HashSet<tblSchedule>();
        }

        [Key]
        public int MarketingCode { get; set; }

        public int? OrganisationID { get; set; }

        [StringLength(50)]
        public string UserCode { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public DateTime? DateStarted { get; set; }

        public DateTime? DateEnded { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public bool Active { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public int OrgTypeID { get; set; }

        public int OrgLevelID { get; set; }

        public DateTime? AvailFromDate { get; set; }

        public DateTime? AvailThruDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? BudgetAmt { get; set; }

        public bool? TrackInCorresp { get; set; }

        public bool? TrackRevenue { get; set; }

        public int? CategoryID { get; set; }

        public bool AvailUseStartDate { get; set; }

        public bool AvailUseEndDate { get; set; }

        public bool AvailNoEndDate { get; set; }

        public virtual lkpCampaignCategory lkpCampaignCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomer> tblCustomers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblJob> tblJobs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchedule> tblSchedules { get; set; }
    }
}
