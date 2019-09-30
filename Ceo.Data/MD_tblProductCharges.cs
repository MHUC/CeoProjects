namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MD_tblProductCharges
    {
        [Key]
        [Column(Order = 0)]
        public Guid MD_ProdChrgID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobID { get; set; }

        public int? ProductID { get; set; }

        [StringLength(50)]
        public string txtPartNum { get; set; }

        [StringLength(50)]
        public string txtProductName { get; set; }

        public decimal? decQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? curSellPrice { get; set; }

        public bool? boolTaxable1 { get; set; }

        public bool? boolTaxable2 { get; set; }

        public bool? boolTaxable3 { get; set; }

        public bool? boolFieldAdded { get; set; }

        public int? SchedProdID { get; set; }

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

        public bool? BatchEquip { get; set; }

        [StringLength(50)]
        public string txtOSEquipDesc { get; set; }

        public bool? boolReplaceEquip { get; set; }

        public bool? boolGenEquip { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool boolDeleted { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool boolSerialized { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool boolInventory { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool boolUIHideChrg { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool boolUILockQty { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool boolUILockChrg { get; set; }

        [Column(TypeName = "ntext")]
        public string txtNotes { get; set; }

        public string Extra1 { get; set; }

        public string Extra2 { get; set; }

        public string Extra3 { get; set; }

        public string Extra4 { get; set; }
    }
}
