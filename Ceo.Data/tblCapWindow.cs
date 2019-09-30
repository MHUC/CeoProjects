namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCapWindow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCapWindow()
        {
            tblCapAdjusts = new HashSet<tblCapAdjust>();
        }

        [Key]
        public int WindowID { get; set; }

        [Required]
        [StringLength(30)]
        public string WindowName { get; set; }

        public int OrganisationID { get; set; }

        public int BuildStartTime { get; set; }

        public int BuildEndTime { get; set; }

        public int? DepleteStartTime { get; set; }

        public int? DepleteEndTime { get; set; }

        public double BuildHours { get; set; }

        public double DepleteHours { get; set; }

        public int ListOrder { get; set; }

        public bool Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCapAdjust> tblCapAdjusts { get; set; }
    }
}
