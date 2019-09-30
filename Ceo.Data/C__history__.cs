namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("__history__")]
    public partial class C__history__
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string table_name { get; set; }

        [Key]
        [Column(Order = 1)]
        public string pk_data_src { get; set; }

        [Key]
        [Column(Order = 2)]
        public string pk_data_dest { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int state { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime ts { get; set; }
    }
}
