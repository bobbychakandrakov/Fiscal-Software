namespace Fiscal_Software
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Remont")]
    public partial class Remont
    {
        public int ID { get; set; }

        public DateTime? PrietV { get; set; }

        public DateTime? ZaqvkaZadadena { get; set; }

        public int? Tehnik { get; set; }

        [StringLength(50)]
        public string OpisanieDefekt { get; set; }

        public DateTime? VurnatNa { get; set; }

        [StringLength(50)]
        public string ChastiPriRemont { get; set; }
    }
}
