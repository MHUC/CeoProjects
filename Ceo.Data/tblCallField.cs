namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCallField
    {
        [Key]
        public int CallFieldID { get; set; }

        public int CallFieldSetID { get; set; }

        [Required]
        [StringLength(100)]
        public string Prompt { get; set; }

        [Required]
        [StringLength(50)]
        public string DBField { get; set; }

        public short DisplayOrder { get; set; }

        public virtual tblCallFieldSet tblCallFieldSet { get; set; }
    }
}
