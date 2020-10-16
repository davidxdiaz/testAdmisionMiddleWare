using System;
using System.Collections.Generic;

namespace pruebaAdmision.Models
{
    public partial class Empleados
    {
        public int IdEmpleado { get; set; }
        public string Descripcion { get; set; }
        public string GeneroSexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }

        public virtual Departamentos IdDepartamentoNavigation { get; set; }
    }
}
