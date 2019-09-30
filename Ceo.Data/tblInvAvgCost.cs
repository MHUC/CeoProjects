namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblInvAvgCost")]
    public partial class tblInvAvgCost
    {
        [Key]
        public int RecordID { get; set; }

        [Column(TypeName = "money")]
        public decimal ValInStock { get; set; }

        public DateTime Date { get; set; }

        public int? NSRecordID { get; set; }

        public int? CompProdID { get; set; }

        public int? ProductID { get; set; }

        public decimal QtyInStock { get; set; }

        [Column(TypeName = "money")]
        public decimal MiscValInStock { get; set; }

        public int? StockLocationID { get; set; }

        public virtual lkpProduct lkpProduct { get; set; }

        public virtual lnkNSInventory lnkNSInventory { get; set; }

        public virtual tblCompleteProduct tblCompleteProduct { get; set; }

        public virtual tblStockLocation tblStockLocation { get; set; }
    }
}
