namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblEmpWorkHour
    {
        [Key]
        public int EmpWorkHourID { get; set; }

        public int EmployeeID { get; set; }

        public int StartTime { get; set; }

        public short DayOfWeek { get; set; }

        [Required]
        [StringLength(50)]
        public string Notes { get; set; }

        public int Duration { get; set; }

        public short? TimeCodeID { get; set; }
    }
}
