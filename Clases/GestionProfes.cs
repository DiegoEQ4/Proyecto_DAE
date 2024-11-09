using Proyecto_DAE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAE.Clases
{
    internal class GestionProfes
    {

        public void InsertProfes(Profesor profesor)
        {
            using (var query = new RegistroAsistenciaContext())
            {

                var profesorExiste = query.Profesors.Any(p => p.CarnetProfesor == profesor.CarnetProfesor);//VALIDACION SI EXISTE ESE PROFESOR

                if (!profesorExiste)
                {

                    query.Profesors.Add(profesor);
                    query.SaveChanges();

                }
                else {

                    MessageBox.Show("PROFESOR YA EXISTENTE", "PRECAUCION!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                
            }
        }
        public void UpdateProfes(Profesor profesor,int id)
        {
            using (var query = new RegistroAsistenciaContext())
            {
                var profesorFind = query.Profesors.Find(id);
                if (profesorFind != null)
                {

                    profesorFind.NombreProfesor = profesor.NombreProfesor;
                    profesorFind.Titulo = profesor.Titulo;
                    profesorFind.Telefono = profesor.Telefono;
                    profesorFind.CorreoInstitucional = profesor.CorreoInstitucional;
                    profesorFind.FechaNacimiento = profesor.FechaNacimiento;

                    query.SaveChanges();
                }
            }
        }

        public void DeleteProfe(int id)
        {
            using (var query = new RegistroAsistenciaContext())
            {
                var profeFind = query.Profesors.Find(id);

                query.Profesors.Remove(profeFind);
                try
                {
                    query.SaveChanges();
                }
                catch (Exception ex) {

                    MessageBox.Show("No se puede eliminar si este profesor imparte una materia");
                
                }
            }
        }
    }
}
