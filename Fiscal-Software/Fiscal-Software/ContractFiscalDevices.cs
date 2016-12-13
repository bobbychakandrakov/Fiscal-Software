namespace Fiscal_Software
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ContractFiscalDevices
    {
        public int ID { get; set; }

        public int ContractType { get; set; }

        public int ObjectId { get; set; }

        public bool? AutomaticNumbering { get; set; }

        public int? ContractN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateTo { get; set; }

        public double? SumMonth { get; set; }

        public double? Sum { get; set; }

        public bool? Valid { get; set; }

        [StringLength(50)]
        public string Notes { get; set; }
    }
}
