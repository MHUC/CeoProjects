namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysMemoOption
    {
        public int ID { get; set; }

        public int OrganisationID { get; set; }

        [StringLength(50)]
        public string Sections { get; set; }

        [StringLength(50)]
        public string Keys { get; set; }

        [Column(TypeName = "ntext")]
        public string Setting { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }
    }
}
