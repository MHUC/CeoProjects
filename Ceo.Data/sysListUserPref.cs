namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysListUserPref
    {
        [Key]
        public int ListUserPrefID { get; set; }

        public int ListFieldID { get; set; }

        public int LoginID { get; set; }

        [StringLength(50)]
        public string DisplayName { get; set; }

        public bool DisplayHide { get; set; }

        public short DisplayOrder { get; set; }

        public int DisplayWidth { get; set; }

        public short DisplaySort { get; set; }

        public bool DisplayLock { get; set; }
    }
}
