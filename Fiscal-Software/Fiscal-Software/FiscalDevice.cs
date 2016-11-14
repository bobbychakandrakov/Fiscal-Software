namespace Fiscal_Software
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FiscalDevice
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(50)]
        public string Manufacturer { get; set; }

        public int? CertificateN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public int? Warranty { get; set; }

        [StringLength(50)]
        public string BulstatManufacturer { get; set; }
    }
}
