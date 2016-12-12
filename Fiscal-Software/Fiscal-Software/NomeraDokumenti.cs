namespace Fiscal_Software
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NomeraDokumenti")]
    public partial class NomeraDokumenti
    {
        public int ID { get; set; }

        public int? ContractN { get; set; }

        public int? Svidetelstvo { get; set; }
    }
}
