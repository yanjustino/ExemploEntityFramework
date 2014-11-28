namespace Vacinas.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("elementonatural")]
    public partial class elementonatural
    {
        public elementonatural()
        {
            alergiamotivoes = new HashSet<alergiamotivo>();
        }

        [Key]
        public long idelementonatural { get; set; }

        [Required]
        [StringLength(50)]
        public string nomeelementonatural { get; set; }

        public virtual ICollection<alergiamotivo> alergiamotivoes { get; set; }
    }
}
