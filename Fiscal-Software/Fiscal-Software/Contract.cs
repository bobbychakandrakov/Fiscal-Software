namespace Fiscal_Software
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contract")]
    public partial class Contract
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? Duration { get; set; }

        public double? MP3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public string PaymentTo { get; set; }

        public bool? Programming { get; set; }

        public bool? ProgrammingArticul { get; set; }

        public bool? Rabota { get; set; }

        public bool? SpareParts { get; set; }

        public bool? SpareModuls { get; set; }

        public bool? Protect { get; set; }
    }
}
