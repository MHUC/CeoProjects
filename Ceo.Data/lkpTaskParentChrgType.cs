namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpTaskParentChrgType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ParentChrgType { get; set; }

        [StringLength(50)]
        public string TableName { get; set; }

        [StringLength(20)]
        public string PrimaryKey { get; set; }

        [StringLength(50)]
        public string ShortDesc { get; set; }

        [StringLength(500)]
        public string LongDesc { get; set; }
    }
}
