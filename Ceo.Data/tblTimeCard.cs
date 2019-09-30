namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblTimeCard
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime StartDate { get; set; }

        public DateTime LastSaved { get; set; }

        public int SavedByLoginID { get; set; }

        public bool Approved { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }

        public virtual tblUserSecurity tblUserSecurity { get; set; }
    }
}
