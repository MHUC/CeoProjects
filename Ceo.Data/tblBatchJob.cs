namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblBatchJob
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBatchJob()
        {
            lnkDocs = new HashSet<lnkDoc>();
            tblBatchCommSumms = new HashSet<tblBatchCommSumm>();
            tblBatchJobProducts = new HashSet<tblBatchJobProduct>();
            tblBatchJobServices = new HashSet<tblBatchJobService>();
            tblPOes = new HashSet<tblPO>();
            tblPOItemIntents = new HashSet<tblPOItemIntent>();
            tblSchedules = new HashSet<tblSchedule>();
            tblTransactions = new HashSet<tblTransaction>();
        }

        [Key]
        public int BatchJobID { get; set; }

        public int MasterScheduleID { get; set; }

        public short BatchDays { get; set; }

        public double BudgPayHrs { get; set; }

        [Column(TypeName = "money")]
        public decimal BudgPayCost { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public int StatusID { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        [Column(TypeName = "money")]
        public decimal BudgProdCost { get; set; }

        [Column(TypeName = "money")]
        public decimal BudgCharge { get; set; }

        [Column(TypeName = "money")]
        public decimal BudgChargeTax { get; set; }

        public int OSEquipID { get; set; }

        public bool BatchEquip { get; set; }

        public int ServConID { get; set; }

        public int OSEquipJobID { get; set; }

        public int BillingPropID { get; set; }

        public int? OrderNum { get; set; }

        [Column(TypeName = "ntext")]
        public string InvoiceNotes { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(12)]
        public string JobNumText { get; set; }

        [Column(TypeName = "ntext")]
        public string PrivateNotes { get; set; }

        public string Extra1 { get; set; }

        public string Extra2 { get; set; }

        public string Extra3 { get; set; }

        public string Extra4 { get; set; }

        public string Extra5 { get; set; }

        public string Extra6 { get; set; }

        public string Extra7 { get; set; }

        public string Extra8 { get; set; }

        public string Extra9 { get; set; }

        public string Extra10 { get; set; }

        public string Extra11 { get; set; }

        public string Extra12 { get; set; }

        public string Extra13 { get; set; }

        public string Extra14 { get; set; }

        public string Extra15 { get; set; }

        public string Extra16 { get; set; }

        public string Extra17 { get; set; }

        public string Extra18 { get; set; }

        public string Extra19 { get; set; }

        public string Extra20 { get; set; }

        public string Extra21 { get; set; }

        public string Extra22 { get; set; }

        public string Extra23 { get; set; }

        public string Extra24 { get; set; }

        public string Extra25 { get; set; }

        public virtual lkpJobStatu lkpJobStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkDoc> lnkDocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBatchCommSumm> tblBatchCommSumms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBatchJobProduct> tblBatchJobProducts { get; set; }

        public virtual tblSchedule tblSchedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBatchJobService> tblBatchJobServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPO> tblPOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPOItemIntent> tblPOItemIntents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchedule> tblSchedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }
    }
}
