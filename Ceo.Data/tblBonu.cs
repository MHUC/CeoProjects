namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblBonu
    {
        [Key]
        [Column(Order = 0)]
        public int BonusID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BonusRuleID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal AmountPaid { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        public int? PayCheckID { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime StartDate { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime EndDate { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime PaidDate { get; set; }
    }
}
