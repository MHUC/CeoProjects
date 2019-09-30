namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblInquiry
    {
        [Key]
        public int InquiryID { get; set; }

        public DateTime DateTime { get; set; }

        public int LoginID { get; set; }

        public int CustomerID { get; set; }

        public virtual tblCustomer tblCustomer { get; set; }

        public virtual tblUserSecurity tblUserSecurity { get; set; }
    }
}
