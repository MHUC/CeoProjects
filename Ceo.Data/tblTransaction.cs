namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTransaction")]
    public partial class tblTransaction
    {
        [Key]
        public int TransactionID { get; set; }

        public int? CustomerID { get; set; }

        public int? ServicingBranchID { get; set; }

        public int? LocationBranchID { get; set; }

        public int InvoiceID { get; set; }

        public int? JobID { get; set; }

        public int TeamID { get; set; }

        public DateTime? DateEntered { get; set; }

        public int? TransTypeID { get; set; }

        public int? TenderID { get; set; }

        [StringLength(75)]
        public string Description { get; set; }

        public bool ManHour { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tip { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tax1 { get; set; }

        public bool Taxable1 { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [StringLength(50)]
        public string Originator { get; set; }

        [StringLength(50)]
        public string Editor { get; set; }

        public DateTime? LastEdited { get; set; }

        public bool Recycle { get; set; }

        [Column(TypeName = "money")]
        public decimal? AddOnCharge { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public int ProfileID { get; set; }

        public int BatchJobID { get; set; }

        public int MiscChargeID { get; set; }

        public int TaxCodeID1 { get; set; }

        public int TaxCodeID2 { get; set; }

        public bool Taxable2 { get; set; }

        public int TaxCodeID3 { get; set; }

        public bool Taxable3 { get; set; }

        [Column(TypeName = "money")]
        public decimal Tax2 { get; set; }

        [Column(TypeName = "money")]
        public decimal Tax3 { get; set; }

        public decimal TaxRate1 { get; set; }

        public decimal TaxRate2 { get; set; }

        public decimal TaxRate3 { get; set; }

        public int ServConID { get; set; }

        public virtual lkpTransactionType lkpTransactionType { get; set; }

        public virtual tblAdjustment tblAdjustment { get; set; }

        public virtual tblBatchJob tblBatchJob { get; set; }

        public virtual tblBranch tblBranch { get; set; }

        public virtual tblCompProfile tblCompProfile { get; set; }

        public virtual tblCustomer tblCustomer { get; set; }

        public virtual tblJob tblJob { get; set; }

        public virtual tblTeam tblTeam { get; set; }

        public virtual tblTender tblTender { get; set; }
    }
}
