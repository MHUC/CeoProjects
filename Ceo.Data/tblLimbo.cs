namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLimbo")]
    public partial class tblLimbo
    {
        [Key]
        public int LimboID { get; set; }

        public int? OrganisationID { get; set; }

        public int? CustomerID { get; set; }

        public virtual tblCustomer tblCustomer { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }
    }
}
