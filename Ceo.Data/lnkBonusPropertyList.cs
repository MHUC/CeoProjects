namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkBonusPropertyList")]
    public partial class lnkBonusPropertyList
    {
        [Key]
        [Column(Order = 0)]
        public int BonusPropertyID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PropertyID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BonusRuleID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string PropertyType { get; set; }
    }
}
