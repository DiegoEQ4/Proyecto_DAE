using Proyecto_DAE.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAE.Clases
{
    internal class GestionGrado
    {
        RegistroAsistenciaContext context = new RegistroAsistenciaContext();

        public void InsertGrado(Grado grado)
        {


            using (var query = new RegistroAsistenciaContext()) {

                var gradoExiste = query.Grados.Any(g => g.NombreGrado == grado.NombreGrado && g.Seccion == grado.Seccion); //VALIDACION SI EXISTE ESE GRADO
                if (gradoExiste)
                {
                    MessageBox.Show("GRADO YA EXISTENTE", "PRECAUCION!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else { 
                    query.Grados.Add(grado);
                    query.SaveChanges();                
                }

            }
        }

        public void UpdateGrado(Grado grado, int id)
        {
            using (var query = new RegistroAsistenciaContext())
            {

                var gradoExiste = query.Grados.Any(g => g.NombreGrado == grado.NombreGrado && g.Seccion == grado.Seccion && g.IdGrado != id);
                if (gradoExiste)
                {
                    MessageBox.Show("GRADO YA EXISTENTE", "PRECAUCION!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    var gradoFind = query.Grados.Find(id);
                    if (gradoFind != null)
                    {
                        gradoFind.NombreGrado = grado.NombreGrado;
                        gradoFind.Seccion = grado.Seccion;
                        gradoFind.Cupos = grado.Cupos;
                        gradoFind.Anio = grado.Anio;
                        query.SaveChanges();
                        MessageBox.Show("Grado Actualizado");
                    }
                    else {

                        MessageBox.Show("NO SE ENCONTRO NINGUN GRADO","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
        }

        public void DeleteGrado(int id)
        {
            using (var query = new RegistroAsistenciaContext())
            {
                var gradoFind = query.Grados.Find(id);
                if (gradoFind != null)
                {

                    try
                    {
                        query.Grados.Remove(gradoFind);
                        query.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Uno o mas estudiante se asocian a este grado no se puede eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else {
                    MessageBox.Show("No se encontro el grado a borrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }
}
