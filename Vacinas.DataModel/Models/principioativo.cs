namespace Vacinas.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("principioativo")]
    public partial class principioativo
    {
        public principioativo()
        {
            alergiamotivoes = new HashSet<alergiamotivo>();
            medicamentoes = new HashSet<medicamento>();
        }

        [Key]
        public long idprincipioativo { get; set; }

        [Required]
        [StringLength(50)]
        public string nomeprincipioativo { get; set; }

        public virtual ICollection<alergiamotivo> alergiamotivoes { get; set; }

        public virtual ICollection<medicamento> medicamentoes { get; set; }
    }
}
