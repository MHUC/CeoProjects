namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCompTimeBlock
    {
        [Key]
        public int TimeBlockID { get; set; }

        public short ParentType { get; set; }

        public int ParentID { get; set; }

        public int EmployeeID { get; set; }

        public int SubTypeID { get; set; }

        public int TimeCodeID { get; set; }

        public DateTime DateTimeIn { get; set; }

        public DateTime DateTimeOut { get; set; }

        [Column(TypeName = "money")]
        public decimal MiscAmt { get; set; }

        [Column(TypeName = "money")]
        public decimal TipAmt { get; set; }

        public int CostToServConLineID { get; set; }

        public short CostToParentType1 { get; set; }

        public int CostToParentID1 { get; set; }

        public short CostToParentType2 { get; set; }

        public int CostToParentID2 { get; set; }

        [Column(TypeName = "money")]
        public decimal BaseRate { get; set; }

        [Column(TypeName = "money")]
        public decimal CommAmt { get; set; }

        public int? PaymentTypeID { get; set; }

        public int? PayCheckID { get; set; }

        public bool? FromMobile { get; set; }

        [StringLength(2000)]
        public string Notes { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? BaseCostAmt { get; set; }

        public virtual lkpEmployeeSubType lkpEmployeeSubType { get; set; }

        public virtual lkpEmpPayType lkpEmpPayType { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }

        public virtual tblPayCheck tblPayCheck { get; set; }
    }
}
