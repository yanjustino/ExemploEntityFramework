namespace Vacinas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vacinacronograma")]
    public partial class vacinacronograma
    {
        public vacinacronograma()
        {
            vacinacronograma1 = new HashSet<vacinacronograma>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idvacinacronograma { get; set; }

        [Required]
        [StringLength(50)]
        public string descricao { get; set; }

        [Required]
        [StringLength(1)]
        public string tipo { get; set; }

        public long valorinicial { get; set; }

        public long valorfinal { get; set; }

        public long idvacina { get; set; }

        public long? idanterior { get; set; }

        public virtual vacina vacina { get; set; }

        public virtual ICollection<vacinacronograma> vacinacronograma1 { get; set; }

        public virtual vacinacronograma vacinacronograma2 { get; set; }
    }
}
