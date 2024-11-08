using System;
using System.Collections.Generic;

namespace Proyecto_DAE.Modelos;

public partial class MateriaGrado
{
    public int IdMateriaGrado { get; set; }

    public int? IdGradoDetalle { get; set; }

    public int? IdMateriaDetalle { get; set; }

    public int? IdProfeDetalle { get; set; }

    public virtual ICollection<Clase> Clases { get; set; } = new List<Clase>();

    public virtual Grado? IdGradoDetalleNavigation { get; set; }

    public virtual Materia? IdMateriaDetalleNavigation { get; set; }

    public virtual Profesor? IdProfeDetalleNavigation { get; set; }
}
