namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpJobSubStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpJobSubStatu()
        {
            lkpJobStatus = new HashSet<lkpJobStatu>();
            lkpRstrSSes = new HashSet<lkpRstrSS>();
            lkpRstrSSes1 = new HashSet<lkpRstrSS>();
            tblJobs = new HashSet<tblJob>();
            tblSchedules = new HashSet<tblSchedule>();
            tblTasks = new HashSet<tblTask>();
            tblTaskScheds = new HashSet<tblTaskSched>();
        }

        [Key]
        public int SubStatusID { get; set; }

        public int StatusID { get; set; }

        public int OrganisationID { get; set; }

        [Required]
        [StringLength(50)]
        public string SubStatusName { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string BarColor { get; set; }

        public bool Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpJobStatu> lkpJobStatus { get; set; }

        public virtual lkpJobStatu lkpJobStatu { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpRstrSS> lkpRstrSSes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpRstrSS> lkpRstrSSes1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblJob> tblJobs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchedule> tblSchedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTask> tblTasks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTaskSched> tblTaskScheds { get; set; }
    }
}
