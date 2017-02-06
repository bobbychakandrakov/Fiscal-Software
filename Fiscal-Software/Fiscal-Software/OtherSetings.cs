namespace Fiscal_Software
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OtherSetings
    {
        public int ID { get; set; }

        public decimal? ProcentDDS { get; set; }

        public decimal? MRZ { get; set; }

        public string Path { get; set; }

        public bool? AvtomatichnoNomerirane { get; set; }
    }
}
