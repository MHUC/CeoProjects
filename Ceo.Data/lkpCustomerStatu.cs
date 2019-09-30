namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpCustomerStatu
    {
        [Key]
        public int StatusCode { get; set; }

        [StringLength(30)]
        public string Status { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public short? Icon { get; set; }
    }
}
