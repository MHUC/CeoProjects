namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sysValidatorLog")]
    public partial class sysValidatorLog
    {
        [Key]
        public int ValidatorLogID { get; set; }

        public int VersionID { get; set; }

        public DateTime ServerDate { get; set; }

        public DateTime ClientDate { get; set; }

        public int NumberOfTests { get; set; }

        public short ErrorSeverity { get; set; }

        [Required]
        [StringLength(50)]
        public string ValidatorVersion { get; set; }

        [Required]
        [StringLength(50)]
        public string ClientName { get; set; }

        [Column(TypeName = "image")]
        public byte[] Results { get; set; }

        public virtual tblVersion tblVersion { get; set; }
    }
}
