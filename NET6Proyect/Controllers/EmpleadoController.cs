using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Entities.Models;

namespace NET6Proyect.Controllers
{
    
    [Route("empleado")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {        
        public readonly DbtrabajoContext _dbContext;

        public EmpleadoController(DbtrabajoContext dbContext)
        {
            _dbContext = dbContext; 
        }

        [HttpGet]
        [Route("Obtener")]
        public async Task<IActionResult> GetEmpleado()
        {
            List<Empleado> list = new List<Empleado>(); 
            
            try
            {
                list= _dbContext.Empleados.ToList();

                return StatusCode(StatusCodes.Status200OK, new {mensaje = "ok", Response = list });   

            }
            catch (Exception ex) {

                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = ex, Response = list });
            }
        }


    }
}
