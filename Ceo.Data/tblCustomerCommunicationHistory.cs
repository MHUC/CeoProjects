namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCustomerCommunicationHistory
    {
        [Key]
        public int CustomerCommunicationHistoryID { get; set; }

        public int OrganisationID { get; set; }

        public int RegionID { get; set; }

        public int BranchID { get; set; }

        public int TemplateID { get; set; }

        public int DemographicID { get; set; }

        public int UserID { get; set; }

        public DateTime SentOn { get; set; }

        [Required]
        [StringLength(100)]
        public string SenderEmail { get; set; }

        [Required]
        [StringLength(100)]
        public string SenderType { get; set; }

        public int NumberOfReceipents { get; set; }
    }
}
