namespace Vacinas.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("posto")]
    public partial class posto
    {
        public posto()
        {
            pacientevacinas = new HashSet<pacientevacina>();
        }

        [Key]
        public long idposto { get; set; }

        [Required]
        [StringLength(50)]
        public string nomeposto { get; set; }

        [StringLength(7)]
        public string tipoposto { get; set; }

        public virtual ICollection<pacientevacina> pacientevacinas { get; set; }
    }
}
