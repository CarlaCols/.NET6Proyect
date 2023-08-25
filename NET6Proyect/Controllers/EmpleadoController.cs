using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Entities.Models;
using System.Diagnostics.Contracts;
using Contract.Interface;

namespace NET6Proyect.Controllers
{

    [Route("empleado")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {        
        public readonly DbtrabajoContext _dbContext;
        public readonly IEmpleadoService _service;

        public EmpleadoController(DbtrabajoContext dbContext, IEmpleadoService service)
        {
            _dbContext = dbContext;
            _service = service;
        }

        [HttpGet]
        [Route("Obtener")]
        public async Task<IActionResult> GetEmpleado()
        {
            var result = _service.GetEmpleado();
            return Ok(result);
        }
        // return StatusCode(StatusCodes.Status200OK, new {mensaje = "ok", Response = list
        //return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = ex, Response = list });

    }
}
