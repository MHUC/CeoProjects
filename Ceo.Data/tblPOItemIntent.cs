namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPOItemIntent")]
    public partial class tblPOItemIntent
    {
        [Key]
        public int POItemIntentID { get; set; }

        public int POItemID { get; set; }

        public double Quantity { get; set; }

        public int? JobID { get; set; }

        [Required]
        [StringLength(50)]
        public string Originator { get; set; }

        public DateTime CreatedOn { get; set; }

        public int? BatchJobID { get; set; }

        public virtual tblBatchJob tblBatchJob { get; set; }

        public virtual tblJob tblJob { get; set; }

        public virtual tblPOItem tblPOItem { get; set; }
    }
}
