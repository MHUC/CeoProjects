namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTender")]
    public partial class tblTender
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTender()
        {
            lnkTendProps = new HashSet<lnkTendProp>();
            tblTransactions = new HashSet<tblTransaction>();
        }

        [Key]
        public int TenderID { get; set; }

        public int OrganisationID { get; set; }

        public int OrgTenderID { get; set; }

        public int CustomerID { get; set; }

        public int LocationBranchID { get; set; }

        public int PayMethodID { get; set; }

        [Required]
        [StringLength(75)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [Column(TypeName = "money")]
        public decimal Tip { get; set; }

        public DateTime DateTendered { get; set; }

        public int DepositID { get; set; }

        [Required]
        [StringLength(100)]
        public string Notes { get; set; }

        public bool Recycle { get; set; }

        [Required]
        [StringLength(50)]
        public string Editor { get; set; }

        public DateTime LastEdited { get; set; }

        public short? QBLocTypeID { get; set; }

        public short? QBLocID { get; set; }

        public short? QBProfileID { get; set; }

        public short? CPStatusID { get; set; }

        public DateTime? CPDateTime { get; set; }

        [StringLength(10)]
        public string CPLastCode { get; set; }

        [Column(TypeName = "ntext")]
        public string CPNotes { get; set; }

        public int? CompletionJobID { get; set; }

        public bool CustomerMerge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkTendProp> lnkTendProps { get; set; }

        public virtual tblBranch tblBranch { get; set; }

        public virtual tblDeposit tblDeposit { get; set; }

        public virtual tblJob tblJob { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }
    }
}
