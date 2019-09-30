namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lnkTendProp
    {
        [Key]
        public int LinkID { get; set; }

        public int? TenderID { get; set; }

        public int TendPropID { get; set; }

        [StringLength(50)]
        public string CharVal { get; set; }

        public DateTime? DateVal { get; set; }

        public int? RefundID { get; set; }

        public virtual lkpTendProp lkpTendProp { get; set; }

        public virtual tblRefund tblRefund { get; set; }

        public virtual tblTender tblTender { get; set; }
    }
}
