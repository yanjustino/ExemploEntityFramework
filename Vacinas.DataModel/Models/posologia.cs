namespace Vacinas.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("posologia")]
    public partial class posologia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idposologia { get; set; }

        [Column(TypeName = "date")]
        public DateTime dataposologia { get; set; }

        public long idmedico { get; set; }

        public long idmedicamento { get; set; }

        [Required]
        [StringLength(250)]
        public string textoposologia { get; set; }

        public long? intervalo { get; set; }

        public long? dias { get; set; }

        public long? idpacientedoenca { get; set; }

        public virtual medicamento medicamento { get; set; }

        public virtual medico medico { get; set; }

        public virtual pacientedoenca pacientedoenca { get; set; }
    }
}
