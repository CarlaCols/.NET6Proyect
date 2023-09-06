using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Empresa
{
    public Guid Id { get; set; }

    public string Nombre { get; set; } = null!;
}
