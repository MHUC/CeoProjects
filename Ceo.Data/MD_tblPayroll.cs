namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MD_tblPayroll
    {
        [Key]
        [Column(Order = 0)]
        public Guid MD_EmpPayrollID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobID { get; set; }

        public int? EmployeeID { get; set; }

        [StringLength(50)]
        public string txtEmpLname { get; set; }

        [StringLength(50)]
        public string txtEmpFname { get; set; }

        [StringLength(255)]
        public string txtNotes { get; set; }

        public bool? boolFieldAdded { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool boolDeleted { get; set; }

        public int? SubTypeID { get; set; }

        public int? AddedFromDispatchRecID { get; set; }
    }
}
