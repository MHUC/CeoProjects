namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpCustomerSubType")]
    public partial class lkpCustomerSubType
    {
        [Key]
        public short CustSubTypeID { get; set; }

        [StringLength(25)]
        public string CustSubType { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public bool Active { get; set; }

        public int? OrganisationID { get; set; }
    }
}
