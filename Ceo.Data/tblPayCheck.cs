namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblPayCheck
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPayCheck()
        {
            tblBatchCommSumms = new HashSet<tblBatchCommSumm>();
            tblCompTimeBlocks = new HashSet<tblCompTimeBlock>();
            tblPaycheckDetails = new HashSet<tblPaycheckDetail>();
            tblPayrollAdjs = new HashSet<tblPayrollAdj>();
        }

        [Key]
        public int PayCheckID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime FirstMinuteOfThisPayPeriod { get; set; }

        public DateTime LastMinuteOfThisPayPeriod { get; set; }

        public bool OTPaid { get; set; }

        public DateTime? CheckDate { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? FirstPaidDate { get; set; }

        public short? PeriodsPerYear { get; set; }

        [StringLength(1)]
        public string sSubTypeIDs { get; set; }

        public int? TotalHours { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBatchCommSumm> tblBatchCommSumms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompTimeBlock> tblCompTimeBlocks { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPaycheckDetail> tblPaycheckDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPayrollAdj> tblPayrollAdjs { get; set; }
    }
}
