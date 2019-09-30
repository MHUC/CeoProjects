namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPayrollAdj")]
    public partial class tblPayrollAdj
    {
        [Key]
        public int PayrollAdjID { get; set; }

        public int EmployeeID { get; set; }

        public short PayAdjTypeID { get; set; }

        public DateTime TransDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(500)]
        public string Notes { get; set; }

        public DateTime LastSaved { get; set; }

        public int SavedByLoginID { get; set; }

        public bool? Recycle { get; set; }

        public int PayCheckID { get; set; }

        public virtual lkpPayAdjType lkpPayAdjType { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }

        public virtual tblPayCheck tblPayCheck { get; set; }

        public virtual tblUserSecurity tblUserSecurity { get; set; }
    }
}
