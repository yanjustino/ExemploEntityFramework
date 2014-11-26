namespace Vacinas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pacientedoenca")]
    public partial class pacientedoenca
    {
        public pacientedoenca()
        {
            posologia = new HashSet<posologia>();
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

        public virtual ICollection<posologia> posologia { get; set; }
    }
}
