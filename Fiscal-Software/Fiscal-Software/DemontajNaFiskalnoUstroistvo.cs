namespace Fiscal_Software
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DemontajNaFiskalnoUstroistvo")]
    public partial class DemontajNaFiskalnoUstroistvo
    {
        public int ID { get; set; }

        public DateTime? DateDemontaj { get; set; }

        public int? FPNomer { get; set; }

        public int? Technician { get; set; }

        public DateTime? OborotOt { get; set; }

        public DateTime? OborotDo { get; set; }

        public double? Suma { get; set; }

        public double? DDS { get; set; }

        [StringLength(50)]
        public string InspectorName { get; set; }

        [StringLength(50)]
        public string InspectorTel { get; set; }

        [StringLength(50)]
        public string Reasons { get; set; }

        [StringLength(50)]
        public string OborotPoGodini { get; set; }

        public int? FiscalID { get; set; }
    }
}
