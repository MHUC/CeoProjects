namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCallCmdProp
    {
        [Key]
        public int CallCmdPropID { get; set; }

        public int CallCmdID { get; set; }

        [Required]
        [StringLength(25)]
        public string Keys { get; set; }

        [Required]
        [StringLength(150)]
        public string Value { get; set; }

        public virtual tblCallCmd tblCallCmd { get; set; }
    }
}
