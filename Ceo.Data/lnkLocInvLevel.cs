namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lnkLocInvLevel
    {
        [Key]
        public int LinkID { get; set; }

        public int ProductID { get; set; }

        public double MinQty { get; set; }

        public double MaxQty { get; set; }

        public double ReOrder { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public int? StockLocationID { get; set; }

        public int? SubStockLocationID { get; set; }

        public virtual lkpProduct lkpProduct { get; set; }

        public virtual tblSubStockLocation tblSubStockLocation { get; set; }

        public virtual tblStockLocation tblStockLocation { get; set; }
    }
}
