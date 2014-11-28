namespace Vacinas.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("doenca")]
    public partial class doenca
    {
        public doenca()
        {
            pacientedoencas = new HashSet<pacientedoenca>();
            vacinas = new HashSet<vacina>();
        }

        [Key]
        public long iddoenca { get; set; }

        [Required]
        [StringLength(50)]
        public string nomedoenca { get; set; }

        public virtual ICollection<pacientedoenca> pacientedoencas { get; set; }

        public virtual ICollection<vacina> vacinas { get; set; }
    }
}
