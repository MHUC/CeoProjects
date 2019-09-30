namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkServConLinePS")]
    public partial class lnkServConLineP
    {
        [Key]
        public int LinkID { get; set; }

        public int ServConLineID { get; set; }

        public short ProdServType { get; set; }

        public int ProdServID { get; set; }

        public virtual tblServConLine tblServConLine { get; set; }
    }
}
