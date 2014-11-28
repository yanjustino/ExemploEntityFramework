namespace Vacinas.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("alergiamotivo")]
    public partial class alergiamotivo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idalergiamotivo { get; set; }

        public long? idelementonatural { get; set; }

        public long? idprincipioativo { get; set; }

        public virtual elementonatural elementonatural { get; set; }

        public virtual principioativo principioativo { get; set; }
    }
}
