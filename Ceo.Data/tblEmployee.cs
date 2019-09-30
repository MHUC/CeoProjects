namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblEmployee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEmployee()
        {
            lnkDocs = new HashSet<lnkDoc>();
            lnkOTRuleORs = new HashSet<lnkOTRuleOR>();
            lnkTaskAssigns = new HashSet<lnkTaskAssign>();
            tblBatchCommSumms = new HashSet<tblBatchCommSumm>();
            tblCommProducts = new HashSet<tblCommProduct>();
            tblCommServices = new HashSet<tblCommService>();
            tblCompTimeBlocks = new HashSet<tblCompTimeBlock>();
            tblDispatchEmpWorkHours = new HashSet<tblDispatchEmpWorkHour>();
            tblEmpLossTeamLinks = new HashSet<tblEmpLossTeamLink>();
            tblEmployeeNotes = new HashSet<tblEmployeeNote>();
            tblEmployeeSignouts = new HashSet<tblEmployeeSignout>();
            tblUnavailEmps = new HashSet<tblUnavailEmp>();
            tblPayChecks = new HashSet<tblPayCheck>();
            tblPayrollAdjs = new HashSet<tblPayrollAdj>();
            tblTimeCards = new HashSet<tblTimeCard>();
            tblWebEvents = new HashSet<tblWebEvent>();
            tblTeamEmployees = new HashSet<tblTeamEmployee>();
        }

        [Key]
        public int EmployeeID { get; set; }

        public int? BranchID { get; set; }

        [StringLength(30)]
        public string SocialSecurityNumber { get; set; }

        [StringLength(30)]
        public string EmployeeNumber { get; set; }

        public int? StatusID { get; set; }

        [StringLength(50)]
        public string Prefix { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string MiddleName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Suffix { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(30)]
        public string Extension { get; set; }

        [StringLength(150)]
        public string Address1 { get; set; }

        [StringLength(150)]
        public string Address2 { get; set; }

        [StringLength(150)]
        public string Address3 { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(100)]
        public string State { get; set; }

        [StringLength(20)]
        public string PostalCode { get; set; }

        [StringLength(30)]
        public string HomePhone { get; set; }

        [StringLength(10)]
        public string HomePhoneA { get; set; }

        [StringLength(30)]
        public string WorkPhone { get; set; }

        [StringLength(10)]
        public string WorkPhoneA { get; set; }

        [StringLength(50)]
        public string MobilePhone { get; set; }

        [StringLength(10)]
        public string MobilePhoneA { get; set; }

        [StringLength(50)]
        public string Pager { get; set; }

        [StringLength(10)]
        public string PagerA { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public DateTime? Birthdate { get; set; }

        public DateTime? DateHired { get; set; }

        public DateTime? DateTerminated { get; set; }

        [Column(TypeName = "money")]
        public decimal? Salary { get; set; }

        [Column(TypeName = "money")]
        public decimal? HourPay { get; set; }

        [StringLength(50)]
        public string SpouseName { get; set; }

        public int? ZoneID { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [StringLength(50)]
        public string ECRelationship1 { get; set; }

        [StringLength(50)]
        public string ECContactName1 { get; set; }

        [StringLength(20)]
        public string ECPhone11 { get; set; }

        [StringLength(10)]
        public string ECPhone11A { get; set; }

        [StringLength(20)]
        public string ECPhone12 { get; set; }

        [StringLength(10)]
        public string ECPhone12A { get; set; }

        [StringLength(255)]
        public string ECNote1 { get; set; }

        [StringLength(50)]
        public string ECRelationship2 { get; set; }

        [StringLength(50)]
        public string ECContactName2 { get; set; }

        [StringLength(20)]
        public string ECPhone21 { get; set; }

        [StringLength(10)]
        public string ECPhone21A { get; set; }

        [StringLength(20)]
        public string ECPhone22 { get; set; }

        [StringLength(10)]
        public string ECPhone22A { get; set; }

        [StringLength(255)]
        public string ECNote2 { get; set; }

        [StringLength(50)]
        public string Originator { get; set; }

        [StringLength(50)]
        public string Editor { get; set; }

        public DateTime? LastEdited { get; set; }

        public bool Recycle { get; set; }

        public bool Archive { get; set; }

        public bool Commission { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public short PayDependents { get; set; }

        [Required]
        [StringLength(25)]
        public string PayDepartment { get; set; }

        public short PayMaritalID { get; set; }

        [Required]
        [StringLength(10)]
        public string PayEmployeeID { get; set; }

        public bool AllowWeb { get; set; }

        [Required]
        [StringLength(50)]
        public string WebPassword { get; set; }

        [Required]
        [StringLength(50)]
        public string WebLogin { get; set; }

        public bool WebJobs { get; set; }

        public bool WebTeamJobs { get; set; }

        public short MaxEmailChars { get; set; }

        public int? EmployeeSubTypeID { get; set; }

        public bool? TrackTravel { get; set; }

        public bool? TrackFirstTravel { get; set; }

        public bool? TrackLastTravel { get; set; }

        public bool UseTimeCards { get; set; }

        public int PayrollType { get; set; }

        [Column(TypeName = "money")]
        public decimal MinimumPay { get; set; }

        public int MinimumPayType { get; set; }

        public bool UseMinimumPay { get; set; }

        [Required]
        [StringLength(255)]
        public string GLPayAcct { get; set; }

        public bool Exempt { get; set; }

        public string Extra1 { get; set; }

        public string Extra2 { get; set; }

        public string Extra3 { get; set; }

        public string Extra4 { get; set; }

        public string Extra5 { get; set; }

        public string Extra6 { get; set; }

        public string Extra7 { get; set; }

        public string Extra8 { get; set; }

        public string Extra9 { get; set; }

        public string Extra10 { get; set; }

        public string Extra11 { get; set; }

        public string Extra12 { get; set; }

        public string Extra13 { get; set; }

        public string Extra14 { get; set; }

        public string Extra15 { get; set; }

        public string Extra16 { get; set; }

        public string Extra17 { get; set; }

        public string Extra18 { get; set; }

        public string Extra19 { get; set; }

        public string Extra20 { get; set; }

        public string Extra21 { get; set; }

        public string Extra22 { get; set; }

        public string Extra23 { get; set; }

        public string Extra24 { get; set; }

        public string Extra25 { get; set; }

        public virtual lkpEmployeeStatu lkpEmployeeStatu { get; set; }

        public virtual lkpEmployeeSubType lkpEmployeeSubType { get; set; }

        public virtual lkpPayMarital lkpPayMarital { get; set; }

        public virtual lkpZone lkpZone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkDoc> lnkDocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkOTRuleOR> lnkOTRuleORs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkTaskAssign> lnkTaskAssigns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBatchCommSumm> tblBatchCommSumms { get; set; }

        public virtual tblBranch tblBranch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCommProduct> tblCommProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCommService> tblCommServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompTimeBlock> tblCompTimeBlocks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDispatchEmpWorkHour> tblDispatchEmpWorkHours { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmpLossTeamLink> tblEmpLossTeamLinks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmployeeNote> tblEmployeeNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmployeeSignout> tblEmployeeSignouts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUnavailEmp> tblUnavailEmps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPayCheck> tblPayChecks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPayrollAdj> tblPayrollAdjs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTimeCard> tblTimeCards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWebEvent> tblWebEvents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTeamEmployee> tblTeamEmployees { get; set; }
    }
}
