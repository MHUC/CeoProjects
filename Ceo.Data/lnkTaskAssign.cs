namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkTaskAssign")]
    public partial class lnkTaskAssign
    {
        [Key]
        public int AssignID { get; set; }

        public int? LoginID { get; set; }

        public int? UserGroupID { get; set; }

        public bool? Accountable { get; set; }

        public int TaskID { get; set; }

        public bool? Owner { get; set; }

        public bool? Assignee { get; set; }

        public int? TeamID { get; set; }

        public int? EmployeeID { get; set; }

        public int TaskSchedID { get; set; }

        public int? PayType { get; set; }

        [Column(TypeName = "money")]
        public decimal? PayRateAmt { get; set; }

        [Column(TypeName = "money")]
        public decimal? PayMiscAmt { get; set; }

        public int? PayDuration { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }

        public virtual tblTask tblTask { get; set; }

        public virtual tblTeam tblTeam { get; set; }

        public virtual tblUserGroup tblUserGroup { get; set; }

        public virtual tblUserSecurity tblUserSecurity { get; set; }
    }
}
