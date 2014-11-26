namespace Vacinas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("paciente")]
    public partial class paciente
    {
        public paciente()
        {
            pacientealergia = new HashSet<pacientealergia>();
            pacientedoenca = new HashSet<pacientedoenca>();
            pacientepeso = new HashSet<pacientepeso>();
            pacientevacina = new HashSet<pacientevacina>();
        }

        [Key]
        public long idpaciente { get; set; }

        [Required]
        [StringLength(80)]
        public string nomepaciente { get; set; }

        [Required]
        [StringLength(1)]
        public string sexo { get; set; }

        [Column(TypeName = "date")]
        public DateTime datanascimento { get; set; }

        [StringLength(2)]
        public string tiposanguineo { get; set; }

        [StringLength(1)]
        public string fatorsanguineo { get; set; }

        [StringLength(150)]
        public string email { get; set; }

        [StringLength(20)]
        public string celular { get; set; }

        public virtual ICollection<pacientealergia> pacientealergia { get; set; }

        public virtual ICollection<pacientedoenca> pacientedoenca { get; set; }

        public virtual ICollection<pacientepeso> pacientepeso { get; set; }

        public virtual ICollection<pacientevacina> pacientevacina { get; set; }
    }
}
