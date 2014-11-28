namespace Vacinas.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("paciente")]
    public partial class paciente
    {
        public paciente()
        {
            pacientealergias = new HashSet<pacientealergia>();
            pacientedoencas = new HashSet<pacientedoenca>();
            pacientepesoes = new HashSet<pacientepeso>();
            pacientevacinas = new HashSet<pacientevacina>();
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

        public virtual ICollection<pacientealergia> pacientealergias { get; set; }

        public virtual ICollection<pacientedoenca> pacientedoencas { get; set; }

        public virtual ICollection<pacientepeso> pacientepesoes { get; set; }

        public virtual ICollection<pacientevacina> pacientevacinas { get; set; }
    }
}
