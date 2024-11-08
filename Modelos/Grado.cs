using System;
using System.Collections.Generic;

namespace Proyecto_DAE.Modelos;

public partial class Grado
{
    public int IdGrado { get; set; }

    public string NombreGrado { get; set; } = null!;

    public string Seccion { get; set; } = null!;

    public int Cupos { get; set; }

    public int? Anio { get; set; }

    public virtual ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

    public virtual ICollection<MateriaGrado> MateriaGrados { get; set; } = new List<MateriaGrado>();
}
