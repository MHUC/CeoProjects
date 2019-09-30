namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpQBExpType")]
    public partial class lkpQBExpType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short QBExpTypeID { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public bool Complete { get; set; }

        public bool IsJunk { get; set; }
    }
}
