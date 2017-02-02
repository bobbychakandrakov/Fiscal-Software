namespace Fiscal_Software
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Plashtaniq")]
    public partial class Plashtaniq
    {
        public int ID { get; set; }

        public int? DogovorID { get; set; }

        public DateTime? DataNa { get; set; }

        public DateTime? DataDo { get; set; }

        [Column(TypeName = "money")]
        public decimal? Suma { get; set; }

        [StringLength(50)]
        public string Notes { get; set; }
    }
}
