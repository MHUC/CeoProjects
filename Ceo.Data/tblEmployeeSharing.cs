namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEmployeeSharing")]
    public partial class tblEmployeeSharing
    {
        [Key]
        public int LinkID { get; set; }

        public int EmployeeID { get; set; }

        public int OrigBranchID { get; set; }

        public int NewBranchID { get; set; }

        public DateTime StartDate { get; set; }
    }
}
