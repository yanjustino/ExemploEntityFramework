namespace Vacinas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("principioativo")]
    public partial class principioativo
    {
        public principioativo()
        {
            alergiamotivo = new HashSet<alergiamotivo>();
            medicamento = new HashSet<medicamento>();
        }

        [Key]
        public long idprincipioativo { get; set; }

        [Required]
        [StringLength(50)]
        public string nomeprincipioativo { get; set; }

        public virtual ICollection<alergiamotivo> alergiamotivo { get; set; }

        public virtual ICollection<medicamento> medicamento { get; set; }
    }
}
