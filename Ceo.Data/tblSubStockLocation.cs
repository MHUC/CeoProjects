namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSubStockLocation")]
    public partial class tblSubStockLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSubStockLocation()
        {
            lnkLocInvLevels = new HashSet<lnkLocInvLevel>();
        }

        [Key]
        public int SubStockLocationID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int StockLocationID { get; set; }

        public int? ParentSubStockLocationID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkLocInvLevel> lnkLocInvLevels { get; set; }

        public virtual tblStockLocation tblStockLocation { get; set; }
    }
}
