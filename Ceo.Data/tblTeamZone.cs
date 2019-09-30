namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblTeamZone
    {
        [Key]
        [Column(Order = 0)]
        public int TeamZoneID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ZoneID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TeamID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Originator { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Editor { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime LastEdited { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public virtual lkpZone lkpZone { get; set; }
    }
}
