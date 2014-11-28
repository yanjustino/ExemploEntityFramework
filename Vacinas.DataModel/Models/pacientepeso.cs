namespace Vacinas.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("pacientepeso")]
    public partial class pacientepeso
    {
        [Key]
        public long idpacientepeso { get; set; }

        [Column(TypeName = "date")]
        public DateTime datapesagem { get; set; }

        [Column(TypeName = "numeric")]
        public decimal peso { get; set; }

        public long idpaciente { get; set; }

        public virtual paciente paciente { get; set; }
    }
}
