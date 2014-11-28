namespace Vacinas.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("pacientedoenca")]
    public partial class pacientedoenca
    {
        public pacientedoenca()
        {
            posologias = new HashSet<posologia>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idpacientedoenca { get; set; }

        public long iddoenca { get; set; }

        [Column(TypeName = "date")]
        public DateTime datadoenca { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datacura { get; set; }

        public long? idpaciente { get; set; }

        public virtual doenca doenca { get; set; }

        public virtual paciente paciente { get; set; }

        public virtual ICollection<posologia> posologias { get; set; }
    }
}
