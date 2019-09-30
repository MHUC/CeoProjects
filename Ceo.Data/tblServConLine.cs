namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblServConLine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblServConLine()
        {
            lnkServConLineEquips = new HashSet<lnkServConLineEquip>();
            lnkServConLinePS = new HashSet<lnkServConLineP>();
        }

        [Key]
        public int ServConLineID { get; set; }

        public int ServConID { get; set; }

        public int ChargeTypeID { get; set; }

        public int UnitID { get; set; }

        [Column(TypeName = "money")]
        public decimal Rate { get; set; }

        [Required]
        [StringLength(255)]
        public string Explanation { get; set; }

        public short CoverageMode { get; set; }

        public decimal CoverageAmount { get; set; }

        public bool FullCoverage { get; set; }

        public bool RestrictPS { get; set; }

        public bool RestrictEquip { get; set; }

        public int RevProductID { get; set; }

        public int RevServiceID { get; set; }

        public bool Taxable1 { get; set; }

        public bool Taxable2 { get; set; }

        public bool Taxable3 { get; set; }

        public decimal Qty { get; set; }

        public virtual lkpChargeType lkpChargeType { get; set; }

        public virtual lkpUnit lkpUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkServConLineEquip> lnkServConLineEquips { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkServConLineP> lnkServConLinePS { get; set; }

        public virtual tblServContract tblServContract { get; set; }
    }
}
