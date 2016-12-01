namespace Fiscal_Software
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Object")]
    public partial class Objects
    {
        public int ID { get; set; }

        public int? ClientId { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string Activity { get; set; }

        [StringLength(50)]
        public string Ekatte { get; set; }

        [Required]
        [StringLength(50)]
        public string Town { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string TDD { get; set; }

        [StringLength(50)]
        public string Mol { get; set; }

        [StringLength(50)]
        public string MolTown { get; set; }

        [StringLength(50)]
        public string MolAddress { get; set; }

        [StringLength(50)]
        public string MolTelephone { get; set; }
    }
}
