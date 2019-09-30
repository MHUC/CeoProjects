namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMiscCharge")]
    public partial class tblMiscCharge
    {
        [Key]
        public int MiscChargeID { get; set; }

        public short? QBLocTypeID { get; set; }

        public short? QBLocID { get; set; }

        [StringLength(255)]
        public string QBIncomeAcct { get; set; }

        public short? QBProfileID { get; set; }
    }
}
