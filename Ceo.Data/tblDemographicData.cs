namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDemographicData")]
    public partial class tblDemographicData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DemographicID { get; set; }

        public bool? LocationDefault { get; set; }

        public bool? LocationPrimary { get; set; }

        public bool? LocationBillTo { get; set; }

        public int? ContactsTarget { get; set; }

        public int? OrderOption { get; set; }

        public bool? AlertFilter { get; set; }

        public int? AlertOption { get; set; }

        public bool? ManualAlert { get; set; }

        public bool? OverCreditLimitAlert { get; set; }

        public bool? PastDueAlert { get; set; }

        public string CustomFieldIDs { get; set; }

        public bool? FilterByDate { get; set; }

        public int? OptionFilterDateRange { get; set; }

        public int? DataJobType { get; set; }

        public bool? StaticDateFilter { get; set; }

        public DateTime? DateRange2 { get; set; }

        public DateTime? DateRange3 { get; set; }

        public bool? RelDateFilter { get; set; }

        [StringLength(100)]
        public string RelDateStart2 { get; set; }

        [StringLength(100)]
        public string RelDateEnd2 { get; set; }

        public int? RelDateStart2Num { get; set; }

        public int? RelDateEnd2Num { get; set; }

        public bool? DateEnterd { get; set; }

        public bool? StaticDate0 { get; set; }

        public DateTime? DateEntered0 { get; set; }

        public DateTime? DateEntered1 { get; set; }

        public bool? RelDate0 { get; set; }

        [StringLength(100)]
        public string RelDateStart0 { get; set; }

        [StringLength(100)]
        public string RelDateEnd0 { get; set; }

        public int? RelDateStart0Num { get; set; }

        public int? RelDateEnd0Num { get; set; }

        public bool? LastContact { get; set; }

        public bool? StaticDate1 { get; set; }

        public DateTime? LastContact0 { get; set; }

        public DateTime? LastContact1 { get; set; }

        public bool? RelDate1 { get; set; }

        [StringLength(100)]
        public string RelDateStart1 { get; set; }

        [StringLength(100)]
        public string RelDateEnd1 { get; set; }

        public int? RelDateStart1Num { get; set; }

        public int? RelDateEnd1Num { get; set; }

        public bool? StatusCheck { get; set; }

        public string StatusIDs { get; set; }

        public bool? ZoneCheck { get; set; }

        public string ZoneIds { get; set; }

        public bool? IntervalByMail { get; set; }

        public bool? IntervalByVoice { get; set; }

        public bool? IntervalByEmail { get; set; }

        public bool? ProdServCheck { get; set; }

        public string ProdServIDS { get; set; }

        public bool? ProfileCheck { get; set; }

        public string ProfileIDs { get; set; }

        public bool? MarketingCheck { get; set; }

        public string MarketingIDs { get; set; }

        [StringLength(100)]
        public string LastContactValue { get; set; }
    }
}
