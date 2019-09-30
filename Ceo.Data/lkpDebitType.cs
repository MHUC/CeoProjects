namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpDebitType
    {
        [Key]
        [Column(Order = 0)]
        public int DebitTypeID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Active { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganisationID { get; set; }
    }
}
