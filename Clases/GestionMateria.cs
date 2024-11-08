using Proyecto_DAE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAE.Clases
{
    internal class GestionMateria
    {
        public void InsertMateria(Materia materia)
        {
            using (var query = new RegistroAsistenciaContext())
            {
                var materiaExiste = query.Materias.Any(m => m.NombreMateria == materia.NombreMateria );

                if (materiaExiste)
                {
                    MessageBox.Show("MATERIA YA EXISTENTE", "PRECAUCION!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {                
                    query.Materias.Add(materia);
                    query.SaveChanges();

                }

            }
        }

        public void UpdateMateria(Materia materia, int id)
        {
            using (var query = new RegistroAsistenciaContext())
            {
                var materiaExiste = query.Materias.
                    Any(m => m.NombreMateria == materia.NombreMateria
                        && m.IdMateria != materia.IdMateria);
                if (materiaExiste)
                {
                    MessageBox.Show("MATERIA YA EXISTENTE", "PRECAUCION!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else { 
                
                    var gradoFind = query.Materias.Find(id);
                    gradoFind.NombreMateria = materia.NombreMateria;
                    gradoFind.DuracionDias = materia.DuracionDias;
                    gradoFind.Descripcion = materia.Descripcion;
                    query.SaveChanges();
                
                
                }

            }
        }

        public void DeleteMateria(int id)
        {
            using (var query = new RegistroAsistenciaContext())
            {
                var materiaFind = query.Materias.Find(id);
                query.Materias.Remove(materiaFind);
                try {
                    query.SaveChanges();
                }catch(Exception ex) {
                    MessageBox.Show("SI UNA MATERIA ES IMPARTIDA NO PUEDE SER ELIMINADA","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }

            }
        }
    }
}
