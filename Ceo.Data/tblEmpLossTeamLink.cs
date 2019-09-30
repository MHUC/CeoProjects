namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblEmpLossTeamLink
    {
        [Key]
        public int LinkID { get; set; }

        public int LossID { get; set; }

        public int EmployeeID { get; set; }

        public virtual tblEmpLossTeam tblEmpLossTeam { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }
    }
}
