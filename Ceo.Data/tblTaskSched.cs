namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblTaskSched
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTaskSched()
        {
            tblTasks = new HashSet<tblTask>();
        }

        [Key]
        public int TaskSchedID { get; set; }

        [Required]
        [StringLength(50)]
        public string Originator { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        public short Priority { get; set; }

        public bool Private { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public int StatusID { get; set; }

        public int SubStatusID { get; set; }

        public DateTime RecurStartDate { get; set; }

        public int? StartTime { get; set; }

        public int? Duration { get; set; }

        public int RecOption { get; set; }

        [Required]
        [StringLength(50)]
        public string Daily { get; set; }

        public int? Weekly { get; set; }

        public int? Monthly { get; set; }

        public int? MonthlyNth { get; set; }

        public int? Yearly { get; set; }

        [Required]
        [StringLength(150)]
        public string Custom { get; set; }

        public DateTime RecurEndDate { get; set; }

        public int Occur { get; set; }

        public DateTime DateEntered { get; set; }

        [Required]
        [StringLength(10)]
        public string Recycle { get; set; }

        public DateTime? FirstStartDate { get; set; }

        public bool Locked { get; set; }

        public int? OrganisationID { get; set; }

        public int? RegionID { get; set; }

        public int? BranchID { get; set; }

        public DateTime? Alarm { get; set; }

        public DateTime? Due { get; set; }

        public short ParentType { get; set; }

        public int ParentID { get; set; }

        public short? RSOffset { get; set; }

        public bool? RSSetTime { get; set; }

        public short ParentChrgType { get; set; }

        public int ParentChrgID { get; set; }

        [StringLength(2)]
        public string RSUnits { get; set; }

        public short TemplateMode { get; set; }

        public int TaskTemplateID { get; set; }

        public bool Payrollable { get; set; }

        public bool IncJobCost { get; set; }

        public bool NotPaid { get; set; }

        public short? AlarmOffset { get; set; }

        [StringLength(2)]
        public string AlarmUnits { get; set; }

        public virtual lkpJobStatu lkpJobStatu { get; set; }

        public virtual lkpJobSubStatu lkpJobSubStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTask> tblTasks { get; set; }
    }
}
