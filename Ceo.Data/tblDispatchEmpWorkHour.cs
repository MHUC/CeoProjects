namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblDispatchEmpWorkHour
    {
        [Key]
        public int DispatchEmpWorkHourID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime StartDate { get; set; }

        public int StartTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Notes { get; set; }

        public int Duration { get; set; }

        public int? HolidayID { get; set; }

        public short? TimeCodeID { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }

        public virtual tblHoliday tblHoliday { get; set; }
    }
}
