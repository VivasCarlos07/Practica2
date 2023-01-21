using System;
using System.Collections.Generic;

namespace Practica2.Models;

public partial class Categorium
{
    public int IdCategoria { get; set; }

    public string Nombre { get; set; } = null!;

    public string Identificador { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string Estado { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
