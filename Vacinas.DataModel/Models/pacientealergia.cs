namespace Vacinas.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("pacientealergia")]
    public partial class pacientealergia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idpacientealergia { get; set; }

        [Column(TypeName = "date")]
        public DateTime datadiagnostico { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dataalta { get; set; }

        [StringLength(250)]
        public string observacoes { get; set; }

        public long? idpaciente { get; set; }

        public virtual paciente paciente { get; set; }
    }
}
