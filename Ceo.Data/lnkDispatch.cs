namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkDispatch")]
    public partial class lnkDispatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lnkDispatch()
        {
            tblBatchCommSumms = new HashSet<tblBatchCommSumm>();
        }

        [Key]
        public int RecordID { get; set; }

        public int EmployeeID { get; set; }

        public short? SubTypeID { get; set; }

        public int? PaymentTypeID { get; set; }

        [Column(TypeName = "money")]
        public decimal? BillingRate { get; set; }

        public int? TeamID { get; set; }

        public DateTime? TeamDate { get; set; }

        public int? BatchJobID { get; set; }

        public int? ScheduleID { get; set; }

        public int? JobID { get; set; }

        public bool? Added { get; set; }

        public bool? Removed { get; set; }

        public DateTime? DispatchChangedOn { get; set; }

        public DateTime? SubTypeChangedOn { get; set; }

        public DateTime? PayInfoChangedOn { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? DispatchOR { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? SubTypeOR { get; set; }

        public int? AppliesToID { get; set; }

        public double? CommRateOrig { get; set; }

        public double? CommRateAdd { get; set; }

        public int? CustomerID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? CustomerLevelOR { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? MasterEmpLevelOR { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? PayInfoOR { get; set; }

        public virtual lkpEmpPayType lkpEmpPayType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBatchCommSumm> tblBatchCommSumms { get; set; }
    }
}
