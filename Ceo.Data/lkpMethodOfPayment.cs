namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lkpMethodOfPayment")]
    public partial class lkpMethodOfPayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lkpMethodOfPayment()
        {
            lkpBillPayers = new HashSet<lkpBillPayer>();
            tblRefunds = new HashSet<tblRefund>();
            lnkOrgCustPayTypes = new HashSet<lnkOrgCustPayType>();
        }

        [Key]
        public int PayMethodID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(100)]
        public string Explanation { get; set; }

        public bool Tender { get; set; }

        public bool PayType { get; set; }

        public bool Refund { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lkpBillPayer> lkpBillPayers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRefund> tblRefunds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkOrgCustPayType> lnkOrgCustPayTypes { get; set; }
    }
}
