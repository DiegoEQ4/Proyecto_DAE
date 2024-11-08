using System;
using System.Collections.Generic;

namespace Proyecto_DAE.Modelos;

public partial class Estudiante
{
    public int CarnetEstudiantes { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string CorreoInstitucional { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public int? Grado { get; set; }

    public virtual ICollection<DetalleAsistencium> DetalleAsistencia { get; set; } = new List<DetalleAsistencium>();

    public virtual Grado? GradoNavigation { get; set; }
}
