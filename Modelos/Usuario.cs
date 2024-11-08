using System;
using System.Collections.Generic;

namespace Proyecto_DAE.Modelos;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public int Tipo { get; set; }

    public virtual ICollection<Profesor> Profesors { get; set; } = new List<Profesor>();
}
