namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MD_AssignedInventory
    {
        [Key]
        [Column(Order = 0)]
        public int MD_AssnInvRecID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid MD_ProdChrgID { get; set; }

        public Guid? MD_NewInventoryID { get; set; }

        public int? SchedProdID { get; set; }

        public int? CompProdID { get; set; }

        public int? BatchProdID { get; set; }

        public int? InvProdID { get; set; }

        public int? CustomerID { get; set; }

        public int? LocationID { get; set; }

        public int? BatchJobID { get; set; }

        public int? JobID { get; set; }

        public int? OnOrderPOItemID { get; set; }

        public int? DropShipPOID { get; set; }

        public int? PendingTransferID { get; set; }

        [StringLength(50)]
        public string Bin { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal decQuantityUsed { get; set; }

        [StringLength(50)]
        public string txtStockLocName { get; set; }

        [StringLength(50)]
        public string txtDesc { get; set; }

        [StringLength(50)]
        public string txtSerialNum { get; set; }

        public decimal? decQuantityCore { get; set; }

        public int? InventoryID { get; set; }

        [Column(TypeName = "money")]
        public decimal? curUnitCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? curUnitSellPrice { get; set; }

        public int? StockLocationID { get; set; }

        public virtual tblStockLocation tblStockLocation { get; set; }
    }
}
