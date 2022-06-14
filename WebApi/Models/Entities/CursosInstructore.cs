using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Models.Entities
{
    public partial class CursosInstructore
    {
        public int Id { get; set; }
        public short IdCurso { get; set; }
        public short IdIstructor { get; set; }
        public DateTime FechaContratacion { get; set; }

        public virtual Curso IdCursoNavigation { get; set; }
        public virtual Instructore IdIstructorNavigation { get; set; }
    }
}
