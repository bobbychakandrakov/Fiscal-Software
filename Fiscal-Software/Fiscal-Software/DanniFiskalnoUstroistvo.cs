namespace Fiscal_Software
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanniFiskalnoUstroistvo")]
    public partial class DanniFiskalnoUstroistvo
    {
        public int ID { get; set; }

        public int Serviz { get; set; }

        public int Obekt { get; set; }

        public int ModelFY { get; set; }

        public string FYNomer { get; set; }

        public string FPNomer { get; set; }

        public DateTime? FPAktivirana { get; set; }

        public DateTime? FPDeaktivirana { get; set; }

        public DateTime? GuaranteeUntil { get; set; }

        public DateTime? PayedSim { get; set; }

        public int? RegNoNap { get; set; }

        public DateTime? RegNapDate { get; set; }

        public int? SimTelNomer { get; set; }

        public int? SimID { get; set; }

        [StringLength(50)]
        public string Nivomer { get; set; }

        [StringLength(50)]
        public string ModelESFP { get; set; }

        [StringLength(50)]
        public string ESFPT { get; set; }

        [StringLength(50)]
        public string Company { get; set; }

        [StringLength(50)]
        public string Town { get; set; }

        [StringLength(50)]
        public string Technician { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }

        public DateTime? RegDate { get; set; }

        public int? FiscalID { get; set; }
    }
}
