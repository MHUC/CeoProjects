namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lnkOrgCustPayType
    {
        [Key]
        public int OrgCustPayID { get; set; }

        public int OrganisationID { get; set; }

        public int PayMethodID { get; set; }

        [StringLength(50)]
        public string OrgDescription { get; set; }

        public bool Active { get; set; }

        public virtual lkpMethodOfPayment lkpMethodOfPayment { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }
    }
}
