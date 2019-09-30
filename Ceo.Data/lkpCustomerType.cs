namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpCustomerType")]
    public partial class lkpCustomerType
    {
        [Key]
        public int CustTypeID { get; set; }

        [StringLength(25)]
        public string CustType { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public bool Active { get; set; }
    }
}
