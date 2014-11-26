namespace Vacinas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico")]
    public partial class medico
    {
        public medico()
        {
            posologia = new HashSet<posologia>();
        }

        [Key]
        public long idmedico { get; set; }

        [Required]
        [StringLength(80)]
        public string nomemedico { get; set; }

        public virtual ICollection<posologia> posologia { get; set; }
    }
}
