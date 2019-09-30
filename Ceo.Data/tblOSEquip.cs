namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOSEquip")]
    public partial class tblOSEquip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOSEquip()
        {
            lnkServConLineEquips = new HashSet<lnkServConLineEquip>();
            tblOSEquip1 = new HashSet<tblOSEquip>();
        }

        [Key]
        public int OSEquipID { get; set; }

        public int ParentID { get; set; }

        public int CustomerID { get; set; }

        public int LocationID { get; set; }

        [Required]
        [StringLength(100)]
        public string Manufac { get; set; }

        [Required]
        [StringLength(30)]
        public string ModelNo { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string SerialNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string SerialNumberM { get; set; }

        [Required]
        [StringLength(100)]
        public string PartNo { get; set; }

        public bool Warranty { get; set; }

        public DateTime? WarrStartDate { get; set; }

        public DateTime? WarrEndDate { get; set; }

        public short StatusID { get; set; }

        public short SubStatusID { get; set; }

        public DateTime InstallDate { get; set; }

        public DateTime? RemovalDate { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public int InventoryID { get; set; }

        public int OrigEquipID { get; set; }

        public short RowLevel { get; set; }

        public int ReplaceForID { get; set; }

        public string Extra1 { get; set; }

        public string Extra2 { get; set; }

        public string Extra3 { get; set; }

        public string Extra4 { get; set; }

        public string Extra5 { get; set; }

        public string Extra6 { get; set; }

        public string Extra7 { get; set; }

        public string Extra8 { get; set; }

        public string Extra9 { get; set; }

        public string Extra10 { get; set; }

        public string Extra11 { get; set; }

        public string Extra12 { get; set; }

        public string Extra13 { get; set; }

        public string Extra14 { get; set; }

        public string Extra15 { get; set; }

        public string Extra16 { get; set; }

        public string Extra17 { get; set; }

        public string Extra18 { get; set; }

        public string Extra19 { get; set; }

        public string Extra20 { get; set; }

        public string Extra21 { get; set; }

        public string Extra22 { get; set; }

        public string Extra23 { get; set; }

        public string Extra24 { get; set; }

        public string Extra25 { get; set; }

        public virtual lnkInventory lnkInventory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lnkServConLineEquip> lnkServConLineEquips { get; set; }

        public virtual tblCustomer tblCustomer { get; set; }

        public virtual tblLocation tblLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOSEquip> tblOSEquip1 { get; set; }

        public virtual tblOSEquip tblOSEquip2 { get; set; }
    }
}
