namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCapAdjust")]
    public partial class tblCapAdjust
    {
        [Key]
        public int AdjustID { get; set; }

        public int BranchID { get; set; }

        public int LinkID { get; set; }

        public int AdjustType { get; set; }

        public double Adjustment { get; set; }

        public virtual tblBranch tblBranch { get; set; }

        public virtual tblCapSlot tblCapSlot { get; set; }

        public virtual tblCapWindow tblCapWindow { get; set; }
    }
}
