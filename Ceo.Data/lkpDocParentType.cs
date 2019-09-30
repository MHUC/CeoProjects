namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpDocParentType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ParentTypeID { get; set; }

        [StringLength(15)]
        public string Description { get; set; }

        public bool? Task { get; set; }

        public bool? Customer { get; set; }

        public bool? Employee { get; set; }

        public bool? Supplier { get; set; }

        [StringLength(25)]
        public string PrimaryKey { get; set; }

        public bool? ServCon { get; set; }

        public bool? TaskSched { get; set; }

        public bool? Job { get; set; }
    }
}
