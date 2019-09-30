namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MD_tblServiceCharges
    {
        [Key]
        [Column(Order = 0)]
        public Guid MD_ServChrgID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChargeTypeID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobID { get; set; }

        public int? ServiceID { get; set; }

        [StringLength(50)]
        public string txtShortDesc { get; set; }

        public decimal? decQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? curUnitCharge { get; set; }

        public bool? boolTaxable1 { get; set; }

        public bool? boolTaxable2 { get; set; }

        public bool? boolTaxable3 { get; set; }

        public bool? boolFieldAdded { get; set; }

        public int? ServConLineID { get; set; }

        public decimal? decServConCovQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? curServConCovChrg { get; set; }

        public bool? boolServConCovMatch { get; set; }

        [StringLength(50)]
        public string txtServConDesc { get; set; }

        public short? intServConCovMode { get; set; }

        public int? OSEquipID { get; set; }

        public int? OSEquipJobID { get; set; }

        [StringLength(50)]
        public string txtOSEquipDesc { get; set; }

        public bool? BatchEquip { get; set; }

        public int? SchedServID { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool boolDeleted { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool boolUIHideChrg { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool boolUILockQty { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool boolUILockChrg { get; set; }

        [Column(TypeName = "ntext")]
        public string txtNotes { get; set; }

        public string Extra1 { get; set; }

        public string Extra2 { get; set; }

        public string Extra3 { get; set; }

        public string Extra4 { get; set; }
    }
}
