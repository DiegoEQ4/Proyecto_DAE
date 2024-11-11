using System;
using System.Collections.Generic;

namespace Proyecto_DAE.Modelos;

public partial class DetalleAsistencium
{
    public int IdDetalleAsistencia { get; set; }

    public int? IdAsistencia { get; set; }

    public int? Estudiante { get; set; }

    public string Estado { get; set; } = null!;

    public string? Detalle { get; set; }

    public virtual Estudiante? EstudianteNavigation { get; set; }

    public virtual Asistencium? IdAsistenciaNavigation { get; set; }
}
