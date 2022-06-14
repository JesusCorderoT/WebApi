using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Models.Entities
{
    public partial class CatCurso
    {
        public CatCurso()
        {
            Cursos = new HashSet<Curso>();
            InverseIdprerequisitoNavigation = new HashSet<CatCurso>();
        }

        public short Id { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Horas { get; set; }
        public short? Idprerequisito { get; set; }
        public bool Activo { get; set; }

        public virtual CatCurso IdprerequisitoNavigation { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
        public virtual ICollection<CatCurso> InverseIdprerequisitoNavigation { get; set; }
    }
}
