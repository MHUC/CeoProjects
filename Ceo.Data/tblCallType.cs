namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCallType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCallType()
        {
            tblCallCmds = new HashSet<tblCallCmd>();
        }

        [Key]
        public int CallTypeID { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        public bool HideMainNav { get; set; }

        public bool SingleWindow { get; set; }

        public short DisplayOrder { get; set; }

        public int OrganisationID { get; set; }

        public bool Active { get; set; }

        public bool CountAsInq { get; set; }

        public short UpdLastCont { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCallCmd> tblCallCmds { get; set; }
    }
}
