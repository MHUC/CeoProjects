namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblUserGroupRightLink
    {
        [Key]
        public int LinkID { get; set; }

        public int GroupRightID { get; set; }

        public int UserGroupID { get; set; }

        public int Data { get; set; }

        public virtual lkpUserGroupRight lkpUserGroupRight { get; set; }

        public virtual tblUserGroup tblUserGroup { get; set; }
    }
}
