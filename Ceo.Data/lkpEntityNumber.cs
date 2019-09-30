namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpEntityNumber")]
    public partial class lkpEntityNumber
    {
        [Key]
        [Column(Order = 0)]
        public int EntityNumberID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NextNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string EntityType { get; set; }
    }
}
