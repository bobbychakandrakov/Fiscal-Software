namespace Fiscal_Software
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string DN { get; set; }

        [StringLength(50)]
        public string Bulstat { get; set; }

        [StringLength(50)]
        public string FDTown { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FDDate { get; set; }

        [StringLength(50)]
        public string FDNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string TDD { get; set; }

        [StringLength(50)]
        public string Town { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Web { get; set; }

        [Required]
        [StringLength(50)]
        public string Mol { get; set; }

        [Required]
        [StringLength(50)]
        public string MolTown { get; set; }

        [Required]
        [StringLength(50)]
        public string MolAddress { get; set; }

        [StringLength(50)]
        public string MolTelephone { get; set; }

        [StringLength(50)]
        public string MolEGN { get; set; }
    }
}
