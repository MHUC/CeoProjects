namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblUserGroupLink
    {
        [Key]
        public int LinkID { get; set; }

        public int UserGroupID { get; set; }

        public int LoginID { get; set; }

        public virtual tblUserGroup tblUserGroup { get; set; }

        public virtual tblUserSecurity tblUserSecurity { get; set; }
    }
}
