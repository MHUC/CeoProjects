namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lkpBillPayer
    {
        [Key]
        public int BillPayerID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string ContactName { get; set; }

        [Required]
        [StringLength(10)]
        public string Phone1A { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone1 { get; set; }

        [Required]
        [StringLength(10)]
        public string Phone2A { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string Address1 { get; set; }

        [Required]
        [StringLength(200)]
        public string Address2 { get; set; }

        [Required]
        [StringLength(200)]
        public string Address3 { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [Required]
        [StringLength(100)]
        public string StateOrProvince { get; set; }

        [Required]
        [StringLength(20)]
        public string PostalCode { get; set; }

        public int PayMethodID { get; set; }

        [Required]
        [StringLength(50)]
        public string CCNo { get; set; }

        public int CCCardType { get; set; }

        public DateTime CCExpirationDate { get; set; }

        [Required]
        [StringLength(50)]
        public string DebitCardNo { get; set; }

        public int DebitCardType { get; set; }

        public DateTime DebitExpirationDate { get; set; }

        public DateTime DebitStartDate { get; set; }

        [Required]
        [StringLength(50)]
        public string DebitIssueNo { get; set; }

        [Required]
        [StringLength(50)]
        public string DirectAcctNo { get; set; }

        [Required]
        [StringLength(50)]
        public string DirectAcctHolder { get; set; }

        public int DirectBankID { get; set; }

        [Required]
        [StringLength(50)]
        public string BarterDesc { get; set; }

        [StringLength(1000)]
        public string Notes { get; set; }

        public bool Active { get; set; }

        public int OrganisationID { get; set; }

        [Required]
        [StringLength(50)]
        public string Originator { get; set; }

        public DateTime? LastEdited { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RecTimestamp { get; set; }

        public virtual lkpMethodOfPayment lkpMethodOfPayment { get; set; }

        public virtual tblOrganisation tblOrganisation { get; set; }
    }
}
