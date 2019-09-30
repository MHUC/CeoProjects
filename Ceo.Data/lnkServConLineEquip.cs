namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lnkServConLineEquip")]
    public partial class lnkServConLineEquip
    {
        [Key]
        public int LinkID { get; set; }

        public int ServConLineID { get; set; }

        public int OSEquipID { get; set; }

        public virtual tblOSEquip tblOSEquip { get; set; }

        public virtual tblServConLine tblServConLine { get; set; }
    }
}
