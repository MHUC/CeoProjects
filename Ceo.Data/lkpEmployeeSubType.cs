namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpEmployeeSubType")]
    public partial class lkpEmployeeSubType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpEmployeeSubType()
        {
            tblCompTimeBlocks = new HashSet<tblCompTimeBlock>();
            tblEmployees = new HashSet<tblEmployee>();
        }

        [Key]
        public int EmployeeSubTypeID { get; set; }

        [StringLength(50)]
        public string EmployeeSubType { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public bool Active { get; set; }

        public int? OrganisationID { get; set; }

        public short IconIndex { get; set; }

        public bool AssignToJobs { get; set; }

        public bool CountManHours { get; set; }

        public bool ShowOnDispatch { get; set; }

        public bool SalesRep { get; set; }

        public bool IsSkill { get; set; }

        public bool JobQualifyingSkill { get; set; }

        public short ReqMode { get; set; }

        public bool MobilePay { get; set; }

        public DateTime? FirstMinuteOfFirstPayPeriod { get; set; }

        public int PayCycleID { get; set; }

        public virtual lkpPayCycle lkpPayCycle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompTimeBlock> tblCompTimeBlocks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmployee> tblEmployees { get; set; }
    }
}
