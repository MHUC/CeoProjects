namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MD_tblJobs
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobID { get; set; }

        public int? CustomerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short CustTypeID { get; set; }

        [StringLength(50)]
        public string txtLname { get; set; }

        [StringLength(50)]
        public string txtFname { get; set; }

        [StringLength(50)]
        public string txtCompany { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatusID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubstatusID { get; set; }

        public int? TeamID { get; set; }

        public DateTime? dtStartDateTime { get; set; }

        public decimal? decArriveWindow { get; set; }

        public decimal? decDuration { get; set; }

        [StringLength(50)]
        public string txtLocationNm { get; set; }

        [Column(TypeName = "ntext")]
        public string txtWorkOrderNotes { get; set; }

        [Column(TypeName = "ntext")]
        public string txtInvoiceNotes { get; set; }

        [StringLength(200)]
        public string txtAddr1 { get; set; }

        [StringLength(200)]
        public string txtAddr2 { get; set; }

        [StringLength(200)]
        public string txtAddr3 { get; set; }

        [StringLength(100)]
        public string txtCity { get; set; }

        [StringLength(100)]
        public string txtState { get; set; }

        [StringLength(20)]
        public string txtZip { get; set; }

        [StringLength(50)]
        public string txtPhone1 { get; set; }

        [StringLength(50)]
        public string txtPhone2 { get; set; }

        [StringLength(50)]
        public string txtPhone3 { get; set; }

        [StringLength(50)]
        public string txtPhone4 { get; set; }

        [StringLength(50)]
        public string txtPhoneType1 { get; set; }

        [StringLength(50)]
        public string txtPhoneType2 { get; set; }

        [StringLength(50)]
        public string txtPhoneType3 { get; set; }

        [StringLength(50)]
        public string txtPhoneType4 { get; set; }

        public decimal? decTaxRate1 { get; set; }

        public decimal? decTaxRate2 { get; set; }

        public decimal? decTaxRate3 { get; set; }

        public bool? boolComplete { get; set; }

        [Column(TypeName = "money")]
        public decimal? curAcctBalance { get; set; }

        public int? DefaultOSEquipID { get; set; }

        public int? DefaultOSEquipJobID { get; set; }

        [StringLength(50)]
        public string txtDefaultOSEquipDesc { get; set; }

        public int? DefaultServConID { get; set; }

        [StringLength(50)]
        public string txtDefaultServConDesc { get; set; }

        public bool? boolSendInvoice { get; set; }

        public bool? DefaultBatchEquip { get; set; }

        [StringLength(100)]
        public string txtJobDesc { get; set; }

        [StringLength(10)]
        public string txtJobNum { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LocationID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LocBranchID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServBranchID { get; set; }

        public DateTime? dtStartGlobTS { get; set; }

        public Guid? MD_JobID { get; set; }

        public int? LastEditedByLoginID { get; set; }
    }
}
