using Proyecto_DAE.Modelos;
using System;
using System.Collections.Generic;
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
                query.Grados.Add(grado);
                query.SaveChanges();

            }
        }

        public void UpdateGrado(Grado grado, int id)
        {
            using (var query = new RegistroAsistenciaContext())
            {
                var gradoFind = query.Grados.Find(id);
                gradoFind.NombreGrado = grado.NombreGrado;
                gradoFind.Seccion = grado.Seccion;
                gradoFind.Cupos = grado.Cupos;
                gradoFind.Anio = grado.Anio;
                query.SaveChanges();

            }
        }

        public void DeleteGrado(int id)
        {
            using (var query = new RegistroAsistenciaContext())
            {
                var gradoFind = query.Grados.Find(id);
                query.Grados.Remove(gradoFind);
                try { 
                    query.SaveChanges();
                
                }catch (Exception ex) {
                    MessageBox.Show("Error: Uno o mas estudiante se asocian a este grado no se puede eliminar" );
                }

            }
        }
    }
}
