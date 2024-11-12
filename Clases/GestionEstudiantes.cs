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
                var estudianteExiste = query.Estudiantes.Any(e => e.CarnetEstudiantes == estudiante.CarnetEstudiantes);//VALIDACION SI EXISTE ESE ESTUDIANTE
                if(estudianteExiste)
                {
                    MessageBox.Show("ESTUDIANTE YA EXISTENTE", "PRECAUCION!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else {
                    if (estudiante.Grado != 0)
                    {

                        query.Estudiantes.Add(estudiante);
                        query.SaveChanges();

                    }
                    else {
                        MessageBox.Show("SELECCIONA UN GRADO SI NO ESTA CREADO, CREALO", "PRECAUCION!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                
                } 
            }
        }

        public void UpdateEstudiante(Estudiante estudiante, int id)
        {
            using (var query = new RegistroAsistenciaContext())
            {
                
                var estudiante_find = query.Estudiantes.Find(id);
                if (estudiante_find == null)
                {

                    MessageBox.Show("ESTUDIANTE NO ENCONTRADO, POR FAVOR VERIFICA EL CARNET", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else { 
                
                    estudiante_find.Nombre = estudiante.Nombre;
                    estudiante_find.Apellido = estudiante.Apellido;
                    estudiante_find.CorreoInstitucional = estudiante.CorreoInstitucional;
                    estudiante_find.FechaNacimiento = estudiante.FechaNacimiento;
                    estudiante_find.Grado = estudiante.Grado;
                    query.SaveChanges();
                
                
                }
            
            }
        }

        public void DeleteEstudiante(int id)
        {
            using (var query = new RegistroAsistenciaContext())
            {
                var estudiante_find = query.Estudiantes.Find(id);

                if (estudiante_find == null)
                {

                    MessageBox.Show("ESTUDIANTE NO ENCONTRADO, POR FAVOR VERIFICA EL CARNET", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else { 
                
                    query.Estudiantes.Remove(estudiante_find);
                    try
                    {
                        query.SaveChanges();

                    }
                    catch (Exception ex) {

                        MessageBox.Show("ESTUDIANTE SE ENCUENTRA EN UNA ASISTENCIA, ELIMINAR ESA ASISTENCIA PRIMERO", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                
                }

            }
        }


    }
}
