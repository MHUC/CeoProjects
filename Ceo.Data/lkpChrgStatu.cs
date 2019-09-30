namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpChrgStatu
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatusID { get; set; }

        [StringLength(50)]
        public string StatusName { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Editable { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Cancelable { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Canceled { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Completed { get; set; }
    }
}
