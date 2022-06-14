using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Models.Entities
{
    public partial class CursosAlumno
    {
        public int Id { get; set; }
        public short IdCurso { get; set; }
        public int Idalumno { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public DateTime FechaBaja { get; set; }
        public byte Calificacion { get; set; }

        public virtual Curso IdCursoNavigation { get; set; }
        public virtual Alumno IdalumnoNavigation { get; set; }
    }
}
