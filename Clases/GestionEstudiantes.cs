using Proyecto_DAE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAE.Clases
{
    internal class GestionEstudiantes
    {

        public void InsertEstudiante(Estudiante estudiante)
        {
            using (var query = new RegistroAsistenciaContext())
            {
                query.Estudiantes.Add(estudiante);
                query.SaveChanges();
            }
        }

        public void UpdateEstudiante(Estudiante estudiante, int id)
        {
            using (var query = new RegistroAsistenciaContext())
            {
                var estudiante_find = query.Estudiantes.Find(id);

                estudiante_find.Nombre = estudiante.Nombre;
                estudiante_find.Apellido = estudiante.Apellido;
                estudiante_find.CorreoInstitucional = estudiante.CorreoInstitucional;
                estudiante_find.FechaNacimiento = estudiante.FechaNacimiento;
                estudiante_find.Grado = estudiante.Grado;
                
                query.SaveChanges();
            
            }
        }

        public void DeleteEstudiante(int id)
        {
            using (var query = new RegistroAsistenciaContext())
            {
                var estudiante_find = query.Estudiantes.Find(id);
                query.Estudiantes.Remove(estudiante_find);
                query.SaveChanges();

            }
        }


    }
}
