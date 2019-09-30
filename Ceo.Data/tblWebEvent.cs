namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblWebEvent
    {
        [Key]
        public int LogID { get; set; }

        public int WebEventID { get; set; }

        public int CustomerID { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Required]
        [StringLength(30)]
        public string IP { get; set; }

        public DateTime TimeStamp { get; set; }

        public int EmployeeID { get; set; }

        public int LoginID { get; set; }

        public virtual lkpWebEvent lkpWebEvent { get; set; }

        public virtual tblCustomer tblCustomer { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }

        public virtual tblUserSecurity tblUserSecurity { get; set; }
    }
}
