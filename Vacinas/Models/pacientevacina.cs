namespace Vacinas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pacientevacina")]
    public partial class pacientevacina
    {
        [Key]
        public long idpacientevacina { get; set; }

        public long idposto { get; set; }

        public long idpaciente { get; set; }

        public long idvacina { get; set; }

        [Column(TypeName = "date")]
        public DateTime datavacina { get; set; }

        [Required]
        [StringLength(50)]
        public string responsavel { get; set; }

        public virtual paciente paciente { get; set; }

        public virtual posto posto { get; set; }

        public virtual vacina vacina { get; set; }
    }
}
