namespace Vacinas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vacina")]
    public partial class vacina
    {
        public vacina()
        {
            pacientevacina = new HashSet<pacientevacina>();
            vacinacronograma = new HashSet<vacinacronograma>();
            doenca = new HashSet<doenca>();
        }

        [Key]
        public long idvacina { get; set; }

        [Required]
        [StringLength(50)]
        public string nomevacina { get; set; }

        public virtual ICollection<pacientevacina> pacientevacina { get; set; }

        public virtual ICollection<vacinacronograma> vacinacronograma { get; set; }

        public virtual ICollection<doenca> doenca { get; set; }
    }
}
