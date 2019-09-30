namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblTeam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTeam()
        {
            lnkTaskAssigns = new HashSet<lnkTaskAssign>();
            tblEmpLossTeams = new HashSet<tblEmpLossTeam>();
            tblEmpLossTeams1 = new HashSet<tblEmpLossTeam>();
            tblTeamEmployees = new HashSet<tblTeamEmployee>();
            tblTransactions = new HashSet<tblTransaction>();
        }

        [Key]
        public int TeamID { get; set; }

        public int BranchID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public bool Active { get; set; }

        public DateTime? DateEntered { get; set; }

        public int? RestrictID { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public bool Monday { get; set; }

        public int? MonStart { get; set; }

        public int? MonEnd { get; set; }

        public bool Tuesday { get; set; }

        public int? TueStart { get; set; }

        public int? TueEnd { get; set; }

        public bool Wednesday { get; set; }

        public int? WedStart { get; set; }

        public int? WedEnd { get; set; }

        public bool Thursday { get; set; }

        public int? ThuStart { get; set; }

        public int? ThuEnd { get; set; }

        public bool Friday { get; set; }

        public int? FriStart { get; set; }

        public int? FriEnd { get; set; }

        public bool Saturday { get; set; }

        public int? SatStart { get; set; }

        public int? SatEnd { get; set; }

        public bool Sunday { get; set; }

        public int? SunStart { get; set; }

        public int? SunEnd { get; set; }

        public bool Block2 { get; set; }

        public bool Block3 { get; set; }

        public int? MonStart2 { get; set; }

        public int? MonStart3 { get; set; }

        public int? MonEnd2 { get; set; }

        public int? MonEnd3 { get; set; }

        public int? TueStart2 { get; set; }

        public int? TueStart3 { get; set; }

        public int? TueEnd2 { get; set; }

        public int? TueEnd3 { get; set; }

        public int? WedStart2 { get; set; }

        public int? WedStart3 { get; set; }

        public int? WedEnd2 { get; set; }

        public int? WedEnd3 { get; set; }

        public int? ThuStart2 { get; set; }

        public int? ThuStart3 { get; set; }

        public int? ThuEnd2 { get; set; }

        public int? ThuEnd3 { get; set; }

        public int? FriStart2 { get; set; }

        public int? FriStart3 { get; set; }

        public int? FriEnd2 { get; set; }

        public int? FriEnd3 { get; set; }

        public int? SatStart2 { get; set; }

        public int? SatStart3 { get; set; }

        public int? SatEnd2 { get; set; }

        public int? SatEnd3 { get; set; }

        public int? SunStart2 { get; set; }

        public int? SunStart3 { get; set; }

        public int? SunEnd2 { get; set; }

        public int? SunEnd3 { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public int? StockLocationID { get; set; }

        [StringLength(10)]
        public string GPSDeviceID { get; set; }

        [StringLength(25)]
        public string ColorCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkTaskAssign> lnkTaskAssigns { get; set; }

        public virtual tblBranch tblBranch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmpLossTeam> tblEmpLossTeams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmpLossTeam> tblEmpLossTeams1 { get; set; }

        public virtual tblStockLocation tblStockLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTeamEmployee> tblTeamEmployees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }
    }
}
