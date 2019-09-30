namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblEmpLossTeam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEmpLossTeam()
        {
            tblEmpLossTeamLinks = new HashSet<tblEmpLossTeamLink>();
        }

        [Key]
        public int LossID { get; set; }

        public int ScheduleID { get; set; }

        public int OrigTeamID { get; set; }

        public int NewTeamID { get; set; }

        public int LastCompJobID { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Editor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmpLossTeamLink> tblEmpLossTeamLinks { get; set; }

        public virtual tblJob tblJob { get; set; }

        public virtual tblSchedule tblSchedule { get; set; }

        public virtual tblTeam tblTeam { get; set; }

        public virtual tblTeam tblTeam1 { get; set; }
    }
}
