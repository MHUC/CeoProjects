namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLocation")]
    public partial class tblLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblLocation()
        {
            lnkInventories = new HashSet<lnkInventory>();
            tblContacts = new HashSet<tblContact>();
            tblOSEquips = new HashSet<tblOSEquip>();
            tblPOes = new HashSet<tblPO>();
            tblSchedules = new HashSet<tblSchedule>();
            tblServContracts = new HashSet<tblServContract>();
        }

        [Key]
        public int LocationID { get; set; }

        public int? CustomerID { get; set; }

        [StringLength(50)]
        public string LocationName { get; set; }

        [StringLength(200)]
        public string Address1 { get; set; }

        [StringLength(200)]
        public string Address2 { get; set; }

        [StringLength(200)]
        public string Address3 { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(100)]
        public string StateOrProvince { get; set; }

        [StringLength(20)]
        public string PostalCode { get; set; }

        public int ZoneID { get; set; }

        public bool Primary { get; set; }

        public bool BillTo { get; set; }

        [StringLength(50)]
        public string MapCode { get; set; }

        [StringLength(400)]
        public string KeyCode { get; set; }

        [StringLength(100)]
        public string AlarmCode { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [StringLength(50)]
        public string Originator { get; set; }

        public DateTime? LastEdited { get; set; }

        public bool PrintOnWO { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public int TaxCodeID1 { get; set; }

        public int TaxCodeID2 { get; set; }

        public int TaxCodeID3 { get; set; }

        [Column(TypeName = "ntext")]
        public string PrivateNotes { get; set; }

        public int? PriceLevelID { get; set; }

        [Required]
        [StringLength(10)]
        public string Latitude { get; set; }

        [Required]
        [StringLength(50)]
        public string Longitude { get; set; }

        public virtual lkpPriceLevel lkpPriceLevel { get; set; }

        public virtual lkpTaxCode lkpTaxCode { get; set; }

        public virtual lkpTaxCode lkpTaxCode1 { get; set; }

        public virtual lkpTaxCode lkpTaxCode2 { get; set; }

        public virtual lkpZone lkpZone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkInventory> lnkInventories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblContact> tblContacts { get; set; }

        public virtual tblCustomer tblCustomer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOSEquip> tblOSEquips { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPO> tblPOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSchedule> tblSchedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblServContract> tblServContracts { get; set; }
    }
}
