namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUnavailEmp")]
    public partial class tblUnavailEmp
    {
        [Key]
        public int UnavailEmpID { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? StartDate { get; set; }

        public int BranchID { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }
    }
}
