namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpOTRule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpOTRule()
        {
            lnkOTRuleAccounts = new HashSet<lnkOTRuleAccount>();
            lnkOTRuleAppls = new HashSet<lnkOTRuleAppl>();
            lnkOTRuleORs = new HashSet<lnkOTRuleOR>();
            tblPaycheckDetails = new HashSet<tblPaycheckDetail>();
        }

        [Key]
        public int OTRuleID { get; set; }

        public short OrganisationID { get; set; }

        public bool Active { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public decimal Multiplier { get; set; }

        public short RuleTypeID { get; set; }

        public decimal? HrsLimit { get; set; }

        public short? DaysLimit { get; set; }

        public short? DayOfWeek { get; set; }

        public int? HolidayID { get; set; }

        public int? StartTime { get; set; }

        public bool? Consec { get; set; }

        public bool IncEndOfShift { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkOTRuleAccount> lnkOTRuleAccounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkOTRuleAppl> lnkOTRuleAppls { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkOTRuleOR> lnkOTRuleORs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPaycheckDetail> tblPaycheckDetails { get; set; }
    }
}
