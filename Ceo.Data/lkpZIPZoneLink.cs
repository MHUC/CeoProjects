namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpZIPZoneLink
    {
        [Key]
        public int ZipZoneID { get; set; }

        public int? ZIPCodeID { get; set; }

        public int? ZoneID { get; set; }

        public virtual lkpZIPCode lkpZIPCode { get; set; }

        public virtual lkpZone lkpZone { get; set; }
    }
}
