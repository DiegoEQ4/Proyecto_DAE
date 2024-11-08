using System;
using System.Collections.Generic;

namespace Proyecto_DAE.Modelos;

public partial class Profesor
{
    public int CarnetProfesor { get; set; }

    public string NombreProfesor { get; set; } = null!;

    public string Titulo { get; set; } = null!;

    public string CorreoInstitucional { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public int? Usuario { get; set; }

    public virtual ICollection<MateriaGrado> MateriaGrados { get; set; } = new List<MateriaGrado>();

    public virtual Usuario? UsuarioNavigation { get; set; }
}
