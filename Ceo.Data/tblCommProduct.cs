namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCommProduct")]
    public partial class tblCommProduct
    {
        [Key]
        public int CommProdID { get; set; }

        public int EmployeeID { get; set; }

        public int ProductID { get; set; }

        public int CompProdID { get; set; }

        public float CommRateOrig { get; set; }

        public float CommRateAdd { get; set; }

        public int TimeBlockID { get; set; }

        public int DispatchRecID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal Amount { get; set; }

        public virtual lkpProduct lkpProduct { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }
    }
}
