namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lnkRegionProfile
    {
        [Key]
        public int LinkID { get; set; }

        public int RegionID { get; set; }

        public int ProfileID { get; set; }

        public virtual tblCompProfile tblCompProfile { get; set; }

        public virtual tblRegion tblRegion { get; set; }
    }
}
