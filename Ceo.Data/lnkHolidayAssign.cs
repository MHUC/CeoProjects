namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkHolidayAssign")]
    public partial class lnkHolidayAssign
    {
        [Key]
        public int RecordID { get; set; }

        public int HolidayID { get; set; }

        public short LocTypeID { get; set; }

        public short LocID { get; set; }

        public virtual tblHoliday tblHoliday { get; set; }
    }
}
