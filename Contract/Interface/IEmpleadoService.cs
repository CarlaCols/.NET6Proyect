using Entities.Models;

namespace Contract.Interface
{
    public interface IEmpleadoService
    {
        public bool AddEmpleado(Empleado empleado);

        public bool EditEmpleado(Empleado empleado);

        public List<Empleado> GetEmpleado();
    }
}
