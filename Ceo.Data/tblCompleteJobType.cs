namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCompleteJobType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCompleteJobType()
        {
            tblSchedules = new HashSet<tblSchedule>();
            tblCompleteQuoteGroups = new HashSet<tblCompleteQuoteGroup>();
        }

        [Key]
        public int CompJobTypeID { get; set; }

        public int QuoteID { get; set; }

        public int JobTypeID { get; set; }

        public bool Include { get; set; }

        [Column(TypeName = "money")]
        public decimal Total { get; set; }

        [Column(TypeName = "money")]
        public decimal Tax1 { get; set; }

        [Column(TypeName = "money")]
        public decimal Tax2 { get; set; }

        [Column(TypeName = "money")]
        public decimal Tax3 { get; set; }

        public virtual lkpQuoteJobType lkpQuoteJobType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchedule> tblSchedules { get; set; }

        public virtual tblQuote tblQuote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompleteQuoteGroup> tblCompleteQuoteGroups { get; set; }
    }
}
