using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Models.Entities
{
    public partial class Curso
    {
        public Curso()
        {
            CursosAlumnos = new HashSet<CursosAlumno>();
            CursosInstructores = new HashSet<CursosInstructore>();
        }

        public short Id { get; set; }
        public short? Idcatcurso { get; set; }
        public DateTime? Fechainicio { get; set; }
        public DateTime? Fechatermino { get; set; }
        public bool? Activo { get; set; }

        public virtual CatCurso IdcatcursoNavigation { get; set; }
        public virtual ICollection<CursosAlumno> CursosAlumnos { get; set; }
        public virtual ICollection<CursosInstructore> CursosInstructores { get; set; }
    }
}
