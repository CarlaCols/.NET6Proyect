using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Empleado
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int Dni { get; set; }

    public string Email { get; set; } = null!;
}
