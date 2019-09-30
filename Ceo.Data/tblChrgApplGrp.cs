namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChrgApplGrp")]
    public partial class tblChrgApplGrp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupID { get; set; }

        public int? GroupOrder { get; set; }

        [StringLength(255)]
        public string Desc { get; set; }

        [StringLength(255)]
        public string Explanation { get; set; }
    }
}
