namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpCustomFieldMaster")]
    public partial class lkpCustomFieldMaster
    {
        [Key]
        public int CustomFieldMasterID { get; set; }

        public int OrganisationID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public short ParentTypeID { get; set; }

        public short FieldIndex { get; set; }

        public short DataTypeID { get; set; }

        public bool IsActive { get; set; }

        public bool IsRequired { get; set; }

        public bool IsRequired_Prospect { get; set; }

        public short DisplayOrder { get; set; }
    }
}
