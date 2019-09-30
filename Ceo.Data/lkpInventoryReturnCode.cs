namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpInventoryReturnCode")]
    public partial class lkpInventoryReturnCode
    {
        [Key]
        public int InventoryReturnCodeID { get; set; }

        public int OrganisationID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public bool IsDefault { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }
    }
}
