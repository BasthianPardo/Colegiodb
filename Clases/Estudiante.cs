namespace Colegiodb.Clases
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Estudiante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idAlumnos { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        public DateTime nacimiento { get; set; }

        public int idCurso { get; set; }

        public virtual Curso Curso { get; set; }
    }
}
