namespace Vacinas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("elementonatural")]
    public partial class elementonatural
    {
        public elementonatural()
        {
            alergiamotivo = new HashSet<alergiamotivo>();
        }

        [Key]
        public long idelementonatural { get; set; }

        [Required]
        [StringLength(50)]
        public string nomeelementonatural { get; set; }

        public virtual ICollection<alergiamotivo> alergiamotivo { get; set; }
    }
}
