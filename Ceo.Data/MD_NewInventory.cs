namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MD_NewInventory
    {
        [Key]
        [Column(Order = 0)]
        public Guid MD_NewInventoryID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobID { get; set; }

        [StringLength(50)]
        public string txtStockLocName { get; set; }

        public int? ProductID { get; set; }

        [StringLength(50)]
        public string txtIntPartNum { get; set; }

        [StringLength(50)]
        public string txtProductName { get; set; }

        [StringLength(150)]
        public string txtVendor { get; set; }

        [StringLength(50)]
        public string txtVendorPartNum { get; set; }

        public decimal? decQuantity { get; set; }

        public decimal? decUnitFactor { get; set; }

        [Column(TypeName = "money")]
        public decimal? curUnitCost { get; set; }

        public bool? boolSerialized { get; set; }

        [Column(TypeName = "money")]
        public decimal? curSellPrice { get; set; }

        [StringLength(50)]
        public string txtSerialNum { get; set; }

        public decimal? decTaxRate1 { get; set; }

        public decimal? decTaxRate2 { get; set; }

        public decimal? decTaxRate3 { get; set; }

        public bool? boolTaxable1 { get; set; }

        public bool? boolTaxable2 { get; set; }

        public bool? boolTaxable3 { get; set; }

        public DateTime? dtTimeAdded { get; set; }

        public int? EmployeeID { get; set; }

        [StringLength(50)]
        public string LoginID { get; set; }

        [StringLength(500)]
        public string txtNotes { get; set; }

        public int? StockLocationID { get; set; }

        public virtual tblStockLocation tblStockLocation { get; set; }
    }
}
