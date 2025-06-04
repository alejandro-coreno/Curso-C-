using System;
using System.Collections.Generic;

namespace Entity.Models;

public partial class Cerveza
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Marcaid { get; set; }

    public virtual Marca Marca { get; set; } = null!;
}
