namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDeposit")]
    public partial class tblDeposit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDeposit()
        {
            tblTenders = new HashSet<tblTender>();
        }

        [Key]
        public int DepositID { get; set; }

        public int OrganisationID { get; set; }

        public DateTime? DepositDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? DepositTotal { get; set; }

        [StringLength(50)]
        public string DepositBankAccount { get; set; }

        [Column(TypeName = "ntext")]
        public string DepositNote { get; set; }

        [StringLength(50)]
        public string Originator { get; set; }

        public DateTime? LastEdited { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public int QBExpID { get; set; }

        [Required]
        [StringLength(36)]
        public string QBTxnID { get; set; }

        public bool IsJunk { get; set; }

        public virtual tblQBExport tblQBExport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTender> tblTenders { get; set; }
    }
}
