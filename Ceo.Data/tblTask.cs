namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTask()
        {
            lnkTaskAssigns = new HashSet<lnkTaskAssign>();
            tblTaskNotes = new HashSet<tblTaskNote>();
        }

        [Key]
        public int TaskID { get; set; }

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

        public DateTime? Alarm { get; set; }

        public DateTime? Due { get; set; }

        public DateTime? Completed { get; set; }

        public int? StartTime { get; set; }

        public int? Duration { get; set; }

        public DateTime DateEntered { get; set; }

        public bool Recycle { get; set; }

        public int OrganisationID { get; set; }

        public int RegionID { get; set; }

        public int BranchID { get; set; }

        public short TaskEdited { get; set; }

        public short ParentType { get; set; }

        public int ParentID { get; set; }

        public short? RSOffset { get; set; }

        public bool? RSSetTime { get; set; }

        public short ParentChrgType { get; set; }

        public int ParentChrgID { get; set; }

        [StringLength(2)]
        public string RSUnits { get; set; }

        public int TaskTemplateID { get; set; }

        public bool Payrollable { get; set; }

        public bool IncJobCost { get; set; }

        public bool NotPaid { get; set; }

        public short? AlarmOffset { get; set; }

        [StringLength(2)]
        public string AlarmUnits { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimeStamp { get; set; }

        public virtual lkpJobStatu lkpJobStatu { get; set; }

        public virtual lkpJobSubStatu lkpJobSubStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkTaskAssign> lnkTaskAssigns { get; set; }

        public virtual tblBranch tblBranch { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }

        public virtual tblRegion tblRegion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTaskNote> tblTaskNotes { get; set; }

        public virtual tblTaskSched tblTaskSched { get; set; }
    }
}
