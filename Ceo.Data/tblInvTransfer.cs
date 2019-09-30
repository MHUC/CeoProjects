namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblInvTransfer")]
    public partial class tblInvTransfer
    {
        [Key]
        public int TransferID { get; set; }

        public DateTime TimeStamp { get; set; }

        [Required]
        [StringLength(50)]
        public string User { get; set; }

        public int TransTicID { get; set; }

        [Required]
        [StringLength(50)]
        public string SBin { get; set; }

        public int DropShipPOID { get; set; }

        public int InvProdID { get; set; }

        public int BatchProdID { get; set; }

        public int SchedProdID { get; set; }

        public int CompProdID { get; set; }

        public int CustomerID { get; set; }

        public int LocationID { get; set; }

        public int BatchJobID { get; set; }

        public int JobID { get; set; }

        [Required]
        [StringLength(50)]
        public string DBin { get; set; }

        public int ProductID { get; set; }

        public bool Completed { get; set; }

        public int OnOrderPOItemID { get; set; }

        public int? SourceStockLocationID { get; set; }

        public int? DestinationStockLocationID { get; set; }

        public virtual tblInvTransTicket tblInvTransTicket { get; set; }

        public virtual tblStockLocation tblStockLocation { get; set; }

        public virtual tblStockLocation tblStockLocation1 { get; set; }
    }
}
