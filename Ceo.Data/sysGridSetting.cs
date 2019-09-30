namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sysGridSetting")]
    public partial class sysGridSetting
    {
        [Key]
        public int GridSettingID { get; set; }

        [Required]
        [StringLength(50)]
        public string FormName { get; set; }

        [Required]
        [StringLength(50)]
        public string GridName { get; set; }

        public int ColIndex { get; set; }

        [Required]
        [StringLength(50)]
        public string ColKey { get; set; }

        public bool ColHidden { get; set; }

        public int ColWidth { get; set; }

        public bool TabStop { get; set; }
    }
}
