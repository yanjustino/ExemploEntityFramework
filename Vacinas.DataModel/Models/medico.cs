namespace Vacinas.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("medico")]
    public partial class medico
    {
        public medico()
        {
            posologias = new HashSet<posologia>();
        }

        [Key]
        public long idmedico { get; set; }

        [Required]
        [StringLength(80)]
        public string nomemedico { get; set; }

        public virtual ICollection<posologia> posologias { get; set; }
    }
}
