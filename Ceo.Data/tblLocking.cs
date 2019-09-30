namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLocking")]
    public partial class tblLocking
    {
        [Key]
        public int LockID { get; set; }

        [Required]
        [StringLength(10)]
        public string ViewName { get; set; }

        [Required]
        [StringLength(50)]
        public string LoginName { get; set; }

        public DateTime OpenTime { get; set; }

        [Required]
        [StringLength(10)]
        public string sDetails { get; set; }

        public int lDetails { get; set; }
    }
}
