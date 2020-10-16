using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pruebaAdmision.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pruebaAdmision.Controllers
{
    [Route("api/[controller]")]
    public class EmpleadoController : Controller
    {
        EmpleadoDataAccessLayer objempleado = new EmpleadoDataAccessLayer();

        [HttpGet]
        [Route("api/Empleado/Index")]
        public IEnumerable<Empleados> Index()
        {
            return objempleado.GetAllEmpleados();
        }

        [HttpPost]
        [Route("api/Empleado/Create")]
        public int Create([FromBody] Empleados empleado)
        {
            return objempleado.AddEmpleado(empleado);
        }

        [HttpPost]
        [Route("api/Departamento/Create")]
        public int CreateDepa([FromBody] Empleados empleado)
        {
            return objempleado.AddEmpleado(empleado);
        }

        [HttpGet]
        [Route("api/Empleado/Details/{id}")]
        public Empleados Details(int id)
        {
            return objempleado.GetEmpleadoData(id);
        }

        [HttpPut]
        [Route("api/Empleado/Edit")]
        public int Edit([FromBody]Empleados empleado)
        {
            return objempleado.UpdateEmpleado(empleado);
        }

        [HttpDelete]
        [Route("api/Empleado/Delete/{id}")]
        public int Delete(int id)
        {
            return objempleado.DeleteEmpleado(id);
        }

        [HttpGet]
        [Route("api/Empleado/GetDepaList")]
        public IEnumerable<Departamentos> Details()
        {
            return objempleado.GetDepartamentos();
        }
    }
}
