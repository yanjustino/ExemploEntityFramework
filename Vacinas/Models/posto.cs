namespace Vacinas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("posto")]
    public partial class posto
    {
        public posto()
        {
            pacientevacina = new HashSet<pacientevacina>();
        }

        [Key]
        public long idposto { get; set; }

        [Required]
        [StringLength(50)]
        public string nomeposto { get; set; }

        [StringLength(7)]
        public string tipoposto { get; set; }

        public virtual ICollection<pacientevacina> pacientevacina { get; set; }
    }
}
