namespace Vacinas.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("medicamento")]
    public partial class medicamento
    {
        public medicamento()
        {
            posologias = new HashSet<posologia>();
            principioativoes = new HashSet<principioativo>();
        }

        [Key]
        public long idmedicamento { get; set; }

        [Required]
        [StringLength(50)]
        public string nomemedicamento { get; set; }

        public virtual ICollection<posologia> posologias { get; set; }

        public virtual ICollection<principioativo> principioativoes { get; set; }
    }
}
