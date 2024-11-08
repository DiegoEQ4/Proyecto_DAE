using System;
using System.Collections.Generic;

namespace Proyecto_DAE.Modelos;

public partial class Asistencium
{
    public int IdAsistencia { get; set; }

    public DateTime FechaHora { get; set; }

    public int? ClaseAsistencia { get; set; }

    public DateTime? FechaHoraFinal { get; set; }

    public virtual Clase? ClaseAsistenciaNavigation { get; set; }

    public virtual ICollection<DetalleAsistencium> DetalleAsistencia { get; set; } = new List<DetalleAsistencium>();
}
