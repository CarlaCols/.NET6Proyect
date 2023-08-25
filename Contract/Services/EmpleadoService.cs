using Contract.Interface;
using Entities.Models;
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
        public List<Empleado> GetEmpleado()
        {
            var list = new List<Empleado>();

            try
            {
                list = _dbContext.Empleados.ToList();

                return list;

            }
            catch (Exception ex)]
            {

                return list;
            }
        }

    }
}
