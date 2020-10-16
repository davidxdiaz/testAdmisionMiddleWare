using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaAdmision.Models
{
    public class EmpleadoDataAccessLayer
    {
        PruebaAdmisionContext db = new PruebaAdmisionContext();
        public IEnumerable<Empleados> GetAllEmpleados()
        {
            try
            {
                return db.Empleados.ToList();
            }
            catch
            {
                throw;
            }
        }

    
        public int AddEmpleado(Empleados empleado)
        {
            try
            {
                db.Empleados.Add(empleado);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public int AddDepa(Departamentos departamento)
        {
            try
            {
                db.Departamentos.Add(departamento);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
  
        public int UpdateEmpleado(Empleados empleado)
        {
            try
            {
                db.Entry(empleado).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

    
        public Empleados GetEmpleadoData(int id)
        {
            try
            {
                Empleados employee = db.Empleados.Find(id);
                return employee;
            }
            catch
            {
                throw;
            }
        }

        
        public int DeleteEmpleado(int id)
        {
            try
            {
                Empleados emp = db.Empleados.Find(id);
                db.Empleados.Remove(emp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

   
        public List<Departamentos> GetDepartamentos()
        {
            List<Departamentos> lstDepa = new List<Departamentos>();
            lstDepa = (from DepaList in db.Departamentos select DepaList).ToList();

            return lstDepa;
        }
    }
}

