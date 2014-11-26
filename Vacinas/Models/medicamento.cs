namespace Vacinas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medicamento")]
    public partial class medicamento
    {
        public medicamento()
        {
            posologia = new HashSet<posologia>();
            principioativo = new HashSet<principioativo>();
        }

        [Key]
        public long idmedicamento { get; set; }

        [Required]
        [StringLength(50)]
        public string nomemedicamento { get; set; }

        public virtual ICollection<posologia> posologia { get; set; }

        public virtual ICollection<principioativo> principioativo { get; set; }
    }
}
