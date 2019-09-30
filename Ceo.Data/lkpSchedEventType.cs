namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpSchedEventType")]
    public partial class lkpSchedEventType
    {
        [Key]
        public int EventTypeID { get; set; }

        [StringLength(50)]
        public string EventType { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public int OrganisationID { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }
    }
}
