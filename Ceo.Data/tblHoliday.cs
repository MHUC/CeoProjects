namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblHoliday
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHoliday()
        {
            lnkHolidayAssigns = new HashSet<lnkHolidayAssign>();
            tblDispatchEmpWorkHours = new HashSet<tblDispatchEmpWorkHour>();
        }

        [Key]
        public int HolidayID { get; set; }

        public DateTime HolidayDate { get; set; }

        [Required]
        [StringLength(50)]
        public string HolidayName { get; set; }

        public short? TimeCodeID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkHolidayAssign> lnkHolidayAssigns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDispatchEmpWorkHour> tblDispatchEmpWorkHours { get; set; }
    }
}
