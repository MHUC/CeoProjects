namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysGraph
    {
        public int ID { get; set; }

        public short? Parent { get; set; }

        [StringLength(50)]
        public string NodeName { get; set; }

        [StringLength(50)]
        public string Key { get; set; }

        public short? Level { get; set; }

        public bool Date { get; set; }

        public short? Sets { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        [Column(TypeName = "ntext")]
        public string SQL { get; set; }

        public bool Active { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }
    }
}
