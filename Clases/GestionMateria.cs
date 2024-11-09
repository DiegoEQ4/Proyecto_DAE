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

                var materiaExiste = query.Materias
                    .Any(m => m.NombreMateria == materia.NombreMateria && m.IdMateria != id);
                if (materiaExiste)
                {
                    MessageBox.Show("MATERIA YA EXISTENTE", "PRECAUCION!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    
                    var materiaFind = query.Materias.Find(id); 

                    if (materiaFind != null)
                    {
                        materiaFind.NombreMateria = materia.NombreMateria;
                        materiaFind.DuracionDias = materia.DuracionDias;
                        materiaFind.Descripcion = materia.Descripcion;
                        query.SaveChanges();

                        MessageBox.Show("Materia actualizada!");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la materia para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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
                    MessageBox.Show("SI UNA MATERIA ES IMPARTIDA NO PUEDE SER ELIMINADA || VERIFICA LA ASIGNACION DE MATERIAS","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }

            }
        }
    }
}
