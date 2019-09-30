namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpBank
    {
        [Key]
        public int BankID { get; set; }

        [Required]
        [StringLength(100)]
        public string BankName { get; set; }

        [Required]
        [StringLength(100)]
        public string BranchName { get; set; }

        [Required]
        [StringLength(200)]
        public string Address1 { get; set; }

        [Required]
        [StringLength(200)]
        public string Address2 { get; set; }

        [Required]
        [StringLength(200)]
        public string Address3 { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(100)]
        public string StateOrProvince { get; set; }

        [StringLength(20)]
        public string PostalCode { get; set; }

        [Required]
        [StringLength(20)]
        public string RoutingNo { get; set; }

        public bool Active { get; set; }

        public int OrganisationID { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }
    }
}
