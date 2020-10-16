using System;
using System.Collections.Generic;

namespace pruebaAdmision.Models
{
    public partial class Departamentos
    {
        public Departamentos()
        {
            Empleados = new HashSet<Empleados>();
        }

        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }
        public string Referencia { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Empleados> Empleados { get; set; }
    }
}
