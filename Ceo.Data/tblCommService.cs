namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCommService")]
    public partial class tblCommService
    {
        [Key]
        public int CommServID { get; set; }

        public int? EmployeeID { get; set; }

        public int ServicesID { get; set; }

        public int CompServID { get; set; }

        public float CommRateOrig { get; set; }

        public float CommRateAdd { get; set; }

        public int TimeBlockID { get; set; }

        public int DispatchRecID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal Amount { get; set; }

        public virtual lkpService lkpService { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }
    }
}
