namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpCustomDropDown")]
    public partial class lkpCustomDropDown
    {
        [Key]
        public int CustomID { get; set; }

        public int? OrganisationID { get; set; }

        public short ParentTypeID { get; set; }

        public short FieldIndex { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
