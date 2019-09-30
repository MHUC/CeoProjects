namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lnkDoc
    {
        [Key]
        public int DocID { get; set; }

        public int ParentID { get; set; }

        public int? CustomerID { get; set; }

        public int? ScheduleID { get; set; }

        public int? BatchJobID { get; set; }

        public int? JobID { get; set; }

        public int? EstimateID { get; set; }

        public int? EmployeeID { get; set; }

        public int? ReportID { get; set; }

        [StringLength(255)]
        public string LocalFile { get; set; }

        [StringLength(255)]
        public string URL { get; set; }

        public int? QuoteID { get; set; }

        public int? SupplierID { get; set; }

        public int? POID { get; set; }

        public short ParentTypeID { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }

        [Required]
        [StringLength(50)]
        public string Originator { get; set; }

        public DateTime DateEntered { get; set; }

        public int? ServConID { get; set; }

        public int? CampaignID { get; set; }

        public int? CallTypeID { get; set; }

        public int? MktActivityTypeID { get; set; }

        public int? TaskID { get; set; }

        public int? DemographicID { get; set; }

        public int? TaskSchedID { get; set; }

        public virtual lkpSupplier lkpSupplier { get; set; }

        public virtual tblDemographic tblDemographic { get; set; }

        public virtual sysReport sysReport { get; set; }

        public virtual tblBatchJob tblBatchJob { get; set; }

        public virtual tblCustomer tblCustomer { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }

        public virtual tblJob tblJob { get; set; }

        public virtual tblPO tblPO { get; set; }

        public virtual tblQuote tblQuote { get; set; }

        public virtual tblSchedule tblSchedule { get; set; }

        public virtual tblSchedule tblSchedule1 { get; set; }
    }
}
