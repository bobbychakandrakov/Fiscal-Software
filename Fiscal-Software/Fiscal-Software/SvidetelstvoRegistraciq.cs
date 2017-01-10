namespace Fiscal_Software
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SvidetelstvoRegistraciq")]
    public partial class SvidetelstvoRegistraciq
    {
        public int id { get; set; }

        public DateTime? RegDate { get; set; }

        public int? SvidetelstvoN { get; set; }

        public int Technician { get; set; }

        public int Contract { get; set; }

        public int? RegNoNap { get; set; }

        public DateTime? RegNoNapIzdaden { get; set; }

        public bool? AutoNumbering { get; set; }

        [StringLength(50)]
        public string Notes { get; set; }

        public DateTime PrietObs { get; set; }

        public DateTime? PrekratenoObs { get; set; }

        [StringLength(50)]
        public string Reason { get; set; }

        public int? FiscalID { get; set; }
    }
}
