namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblTeamEmployee
    {
        [Key]
        public int TeamEmpID { get; set; }

        public int? TeamID { get; set; }

        public int? EmployeeID { get; set; }

        [StringLength(50)]
        public string Originator { get; set; }

        [StringLength(50)]
        public string Editor { get; set; }

        public DateTime? LastEdited { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }

        public virtual tblTeam tblTeam { get; set; }
    }
}
