namespace Vacinas.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("vacina")]
    public partial class vacina
    {
        public vacina()
        {
            pacientevacinas = new HashSet<pacientevacina>();
            vacinacronogramas = new HashSet<vacinacronograma>();
            doencas = new HashSet<doenca>();
        }

        [Key]
        public long idvacina { get; set; }

        [Required]
        [StringLength(50)]
        public string nomevacina { get; set; }

        public virtual ICollection<pacientevacina> pacientevacinas { get; set; }

        public virtual ICollection<vacinacronograma> vacinacronogramas { get; set; }

        public virtual ICollection<doenca> doencas { get; set; }
    }
}
