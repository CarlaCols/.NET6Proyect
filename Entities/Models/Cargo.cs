using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Cargo
{
    public Guid? Id { get; set; }

    public int Idempleado { get; set; }

    public string Nombre { get; set; } = null!;

    public string Decripcion { get; set; } = null!;
}
