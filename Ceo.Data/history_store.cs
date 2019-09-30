namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class history_store
    {
        public DateTime timemark { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string table_name { get; set; }

        [Required]
        [StringLength(400)]
        public string pk_date_src { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(400)]
        public string pk_date_dest { get; set; }

        public short record_state { get; set; }
    }
}
