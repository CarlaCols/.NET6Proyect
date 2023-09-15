using Contract.Interface;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        public readonly DbtrabajoContext _dbContext;
        public EmpleadoService(DbtrabajoContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        //Obtener Lista de empleados
        public List<Empleado> GetEmpleado()
        {
            var list = new List<Empleado>();

            try
            {
                list = _dbContext.Empleados.ToList();

                return list;

            }
            catch (Exception ex)
            {

                return list;
            }
        }
        //Agregar nuevo empleado 
        public bool AddEmpleado(Empleado empleado)
        {
           
           var empleadoExist = _dbContext.Empleados.Where(p => p.Dni == empleado.Dni).FirstOrDefault();
           
            if(empleadoExist != null ) 
                return false;

            empleado.Id = Guid.NewGuid();
            
            _dbContext.Empleados.Add(empleado);
            _dbContext.SaveChanges();

            return true;    
        }

        //Editar empleado 
        public bool EditEmpleado(Empleado empleado)
        {
            var empleadoModified = _dbContext.Empleados.Where(w=>w.Dni ==empleado.Dni).FirstOrDefault();

            if (empleadoModified == null)
            {               
               return false;    
            }
            //empleado.Id = empleado.Id;  
            empleado.Dni = empleadoModified.Dni;
            empleado.Nombre = empleadoModified.Nombre;
            empleado.Apellido = empleadoModified.Apellido;
            empleado.Email = empleadoModified.Email;
            
            _dbContext.Add(empleado);
            _dbContext.SaveChanges();
            
            return true;    
        }
    }
}

