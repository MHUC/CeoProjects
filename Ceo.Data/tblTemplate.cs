namespace Ceo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTemplate")]
    public partial class tblTemplate
    {
        [Key]
        [Column(Order = 0)]
        public int TemplateID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganisationID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegionID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string MailSubject { get; set; }

        [Key]
        [Column(Order = 7)]
        public string MailBody { get; set; }
    }
}
