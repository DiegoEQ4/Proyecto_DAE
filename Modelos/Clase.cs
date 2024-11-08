using System;
using System.Collections.Generic;

namespace Proyecto_DAE.Modelos;

public partial class Clase
{
    public int IdClase { get; set; }

    public string ContenidoClase { get; set; } = null!;

    public int? IdMateriaDetalle { get; set; }

    public decimal DuracionHoras { get; set; }

    public virtual ICollection<Asistencium> Asistencia { get; set; } = new List<Asistencium>();

    public virtual MateriaGrado? IdMateriaDetalleNavigation { get; set; }
}
