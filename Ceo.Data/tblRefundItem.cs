namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRefundItem")]
    public partial class tblRefundItem
    {
        [Key]
        public int RefundItemID { get; set; }

        public int? RefundID { get; set; }

        public int? CompProdID { get; set; }

        public int? CompServID { get; set; }

        public decimal Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal CustomerRefund { get; set; }

        [Column(TypeName = "money")]
        public decimal SupplierRefund { get; set; }

        public bool Tax1 { get; set; }

        [Column(TypeName = "money")]
        public decimal Tax1Amount { get; set; }

        public bool Tax2 { get; set; }

        [Column(TypeName = "money")]
        public decimal Tax2Amount { get; set; }

        public bool Tax3 { get; set; }

        [Column(TypeName = "money")]
        public decimal Tax3Amount { get; set; }

        public int? ReturnID { get; set; }

        public virtual tblCompleteProduct tblCompleteProduct { get; set; }

        public virtual tblCompleteService tblCompleteService { get; set; }

        public virtual tblRefund tblRefund { get; set; }

        public virtual tblReturn tblReturn { get; set; }
    }
}
