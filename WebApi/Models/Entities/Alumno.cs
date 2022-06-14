using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Models.Entities
{
    public partial class Alumno
    {
        public Alumno()
        {
            CursosAlumnos = new HashSet<CursosAlumno>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Curp { get; set; }
        public decimal? Sueldo { get; set; }
        public short Idestadoorigen { get; set; }
        public short IdEstatus { get; set; }

        public virtual EstatusAlumno IdEstatusNavigation { get; set; }
        public virtual Estado IdestadoorigenNavigation { get; set; }
        public virtual ICollection<CursosAlumno> CursosAlumnos { get; set; }
    }
}
