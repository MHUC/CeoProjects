namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBatchCommSumm")]
    public partial class tblBatchCommSumm
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BatchJobID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpInstID { get; set; }

        [Column(TypeName = "money")]
        public decimal CommAmtOrig { get; set; }

        [Column(TypeName = "money")]
        public decimal CommAmtAdd { get; set; }

        public int PayCheckID { get; set; }

        public short ChargeType { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChargeID { get; set; }

        public virtual lnkDispatch lnkDispatch { get; set; }

        public virtual tblBatchJob tblBatchJob { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }

        public virtual tblPayCheck tblPayCheck { get; set; }
    }
}
