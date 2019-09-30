namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCallCmd
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCallCmd()
        {
            tblCallCmdProps = new HashSet<tblCallCmdProp>();
        }

        [Key]
        public int CallCmdID { get; set; }

        public int CallTypeID { get; set; }

        public short CmdType { get; set; }

        [Required]
        [StringLength(150)]
        public string LinkLabel { get; set; }

        public bool BeginGroup { get; set; }

        public short DisplayOrder { get; set; }

        public short ShowOnToolbar { get; set; }

        [Required]
        [StringLength(1000)]
        public string Prompt { get; set; }

        public int CallFieldSetID { get; set; }

        public bool AutoRun { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCallCmdProp> tblCallCmdProps { get; set; }

        public virtual tblCallFieldSet tblCallFieldSet { get; set; }

        public virtual tblCallType tblCallType { get; set; }
    }
}
