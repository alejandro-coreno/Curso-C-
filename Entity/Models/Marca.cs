using System;
using System.Collections.Generic;

namespace Entity.Models;

public partial class Marca
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Cerveza> Cervezas { get; set; } = new List<Cerveza>();
}
