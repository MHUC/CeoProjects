namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblAdjustment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAdjustment()
        {
            tblTransactions = new HashSet<tblTransaction>();
        }

        [Key]
        public int AdjustmentID { get; set; }

        public int OrgAdjustmentID { get; set; }

        public int OrganisationID { get; set; }

        public int AdjustmentTypeID { get; set; }

        public int CustomerID { get; set; }

        public int LocationBranchID { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public bool Taxable1 { get; set; }

        [Required]
        [StringLength(75)]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string Notes { get; set; }

        public DateTime DateEntered { get; set; }

        public bool Recycle { get; set; }

        [Required]
        [StringLength(50)]
        public string Editor { get; set; }

        public DateTime LastEdited { get; set; }

        public int TaxCodeID1 { get; set; }

        public int TaxCodeID2 { get; set; }

        public bool Taxable2 { get; set; }

        public int TaxCodeID3 { get; set; }

        public bool Taxable3 { get; set; }

        public int QBExpID { get; set; }

        [Required]
        [StringLength(36)]
        public string QBTxnID { get; set; }

        public decimal TaxPct1 { get; set; }

        public decimal TaxPct2 { get; set; }

        public decimal TaxPct3 { get; set; }

        public short? QBLocTypeID { get; set; }

        public short? QBLocID { get; set; }

        [StringLength(255)]
        public string QBAcct { get; set; }

        public short? QBProfileID { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? AmountPlusTax { get; set; }

        public bool CustomerMerge { get; set; }

        public bool IsRefund { get; set; }

        public virtual lkpAdjustmentType lkpAdjustmentType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }

        public virtual tblBranch tblBranch { get; set; }

        public virtual tblCustomer tblCustomer { get; set; }
    }
}
