namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpJobStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpJobStatu()
        {
            lkpJobSubStatus = new HashSet<lkpJobSubStatu>();
            lkpRstrSSes = new HashSet<lkpRstrSS>();
            lkpRstrSSes1 = new HashSet<lkpRstrSS>();
            tblBatchJobs = new HashSet<tblBatchJob>();
            tblTasks = new HashSet<tblTask>();
            tblTaskScheds = new HashSet<tblTaskSched>();
            tblJobs = new HashSet<tblJob>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatusID { get; set; }

        [StringLength(50)]
        public string StatusName { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(50)]
        public string BarColor { get; set; }

        public bool CanRecur { get; set; }

        public bool JOB { get; set; }

        public bool ESTIMATE { get; set; }

        public bool TASK { get; set; }

        public bool PSAssign { get; set; }

        public bool CompWiz { get; set; }

        public bool ActPer { get; set; }

        public bool RevAct { get; set; }

        public bool RevProj { get; set; }

        public bool Editable { get; set; }

        public bool Cancelable { get; set; }

        public bool Canceled { get; set; }

        public bool Completed { get; set; }

        public bool Invoice { get; set; }

        public bool Capacity { get; set; }

        public bool PendingJob { get; set; }

        public bool CanceledJob { get; set; }

        public bool ActiveJob { get; set; }

        public bool CompleteJob { get; set; }

        public bool BatchStats { get; set; }

        public bool BatchBudgRev { get; set; }

        public bool rptInvoice { get; set; }

        public bool SchedChrg { get; set; }

        public bool CompChrg { get; set; }

        public bool UseTrans { get; set; }

        public bool AssnUseTimeBlocks { get; set; }

        public bool PnL { get; set; }

        public bool Dispatch { get; set; }

        public bool ReservCnt { get; set; }

        public bool Proximity { get; set; }

        public bool SchedAssist { get; set; }

        public bool EstLoss { get; set; }

        public bool EstWon { get; set; }

        public bool TaskOpen { get; set; }

        public bool TaskClosed { get; set; }

        public bool TaskCanceled { get; set; }

        public bool RevProjView { get; set; }

        public bool InvCheckGrid { get; set; }

        public bool InvCheckGridQuery { get; set; }

        public bool GenEquip { get; set; }

        public bool MobileViewable { get; set; }

        public bool MobileEditable { get; set; }

        public bool PickList { get; set; }

        public bool AutoGenOrderNum { get; set; }

        public bool Invoicable { get; set; }

        public bool? SchedOverlap { get; set; }

        public bool? CreatesTimeBlocks { get; set; }

        public bool Startable { get; set; }

        public int? DefaultSubStatusID { get; set; }

        public virtual lkpJobSubStatu lkpJobSubStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpJobSubStatu> lkpJobSubStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpRstrSS> lkpRstrSSes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpRstrSS> lkpRstrSSes1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBatchJob> tblBatchJobs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTask> tblTasks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTaskSched> tblTaskScheds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblJob> tblJobs { get; set; }
    }
}
