using System;
using System.Collections.Generic;

namespace Proyecto_DAE.Modelos;

public partial class Materia
{
    public int IdMateria { get; set; }

    public string NombreMateria { get; set; } = null!;

    public int DuracionDias { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<MateriaGrado> MateriaGrados { get; set; } = new List<MateriaGrado>();
}
