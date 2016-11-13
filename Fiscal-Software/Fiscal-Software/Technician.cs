namespace Fiscal_Software
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Technician
    {
        public int ID { get; set; }

        public int CompanyID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(10)]
        public string EGN { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        public virtual Company Company { get; set; }
    }
}
