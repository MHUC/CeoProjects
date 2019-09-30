namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysListField
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ListFieldID { get; set; }

        public short ListGroupID { get; set; }

        public short DataType { get; set; }

        public bool ShowInSearch { get; set; }

        public bool ShowInUI { get; set; }

        public short DisplayOrder { get; set; }

        public bool DisplayHide { get; set; }

        public int DisplayWidth { get; set; }

        public short DisplayAlign { get; set; }

        public bool UserCanHide { get; set; }

        public bool UserCanSort { get; set; }

        public bool UserCanLock { get; set; }

        public bool UserCanRename { get; set; }

        [Required]
        [StringLength(50)]
        public string FieldName { get; set; }

        [Required]
        [StringLength(50)]
        public string UserFieldName { get; set; }

        [Required]
        [StringLength(50)]
        public string KeyID { get; set; }

        public virtual sysListGroup sysListGroup { get; set; }
    }
}
