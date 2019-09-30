namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysOption
    {
        public int ID { get; set; }

        public int? OrganisationID { get; set; }

        [StringLength(50)]
        public string Sections { get; set; }

        [StringLength(50)]
        public string Keys { get; set; }

        [StringLength(255)]
        public string Setting { get; set; }
    }
}
