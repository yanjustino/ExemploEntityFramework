namespace Vacinas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("doenca")]
    public partial class doenca
    {
        public doenca()
        {
            pacientedoenca = new HashSet<pacientedoenca>();
            vacina = new HashSet<vacina>();
        }

        [Key]
        public long iddoenca { get; set; }

        [Required]
        [StringLength(50)]
        public string nomedoenca { get; set; }

        public virtual ICollection<pacientedoenca> pacientedoenca { get; set; }

        public virtual ICollection<vacina> vacina { get; set; }
    }
}
