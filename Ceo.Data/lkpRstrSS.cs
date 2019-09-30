namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpRstrSS")]
    public partial class lkpRstrSS
    {
        [Key]
        [Column(Order = 0)]
        public int RstrID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganisationID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatusID { get; set; }

        public int? SubStatusID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RstrStatusID { get; set; }

        public int? RstrSubStatusID { get; set; }

        public virtual lkpJobStatu lkpJobStatu { get; set; }

        public virtual lkpJobStatu lkpJobStatu1 { get; set; }

        public virtual lkpJobSubStatu lkpJobSubStatu { get; set; }

        public virtual lkpJobSubStatu lkpJobSubStatu1 { get; set; }
    }
}
